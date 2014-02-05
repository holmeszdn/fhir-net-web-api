﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Support;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Hl7.Fhir.Rest
{
    public static class HttpUtil
    {
        public const string CONTENTLOCATION = "Content-Location";
        public const string LOCATION = "Location";
        public const string LASTMODIFIED = "Last-Modified";
        public const string CATEGORY = "Category";

        public const string RESTPARAM_FORMAT = "_format";

        public const string SEARCH_PARAM_ID = "_id";
        public const string SEARCH_PARAM_COUNT = "_count";
        public const string SEARCH_PARAM_INCLUDE = "_include";
        public const string HISTORY_PARAM_SINCE = "_since";
        public const string SEARCH_PARAM_SORT = "_sort";
        public const string HISTORY_PARAM_COUNT = SEARCH_PARAM_COUNT;

        public static byte[] ReadAllFromStream(Stream s, int contentLength)
        {
            if (contentLength == 0) return null;

            //int bufferSize = contentLength < 4096 ? contentLength : 4096;
            int bufferSize = 4096;

            byte[] byteBuffer = new byte[bufferSize];
            MemoryStream buffer = new MemoryStream();

            int readLen = s.Read(byteBuffer, 0, byteBuffer.Length);

            while (readLen > 0)
            {
                buffer.Write(byteBuffer, 0, readLen);
                readLen = s.Read(byteBuffer, 0, byteBuffer.Length);
            }

            return buffer.ToArray();
        }

        public static IEnumerable<string> SplitNotInQuotes(char c, string value)
        {
            var categories = Regex.Split(value, c + "(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)")
                                .Select(s => s.Trim())
                                .Where(s => !String.IsNullOrEmpty(s));
            return categories;
        }

        public static ICollection<Tag> ParseCategoryHeader(string value)
        {
            if (String.IsNullOrEmpty(value)) return new List<Tag>();

            var result = new List<Tag>();

            var categories = SplitNotInQuotes(',', value);

            foreach (var category in categories)
            {
                var values = SplitNotInQuotes(';', category);

                if (values.Count() >= 1)
                {
                    var term = values.First();

                    var pars = values.Skip(1).Select( v =>
                        { 
                            var vsplit = v.Split('=');
                            var item1 = vsplit[0].Trim();
                            var item2 = vsplit.Length > 1 ? vsplit[1].Trim() : null;
                            return new Tuple<string,string>(item1,item2);
                        });

                    var scheme = new Uri(pars.Where(t => t.Item1 == "scheme").Select(t => t.Item2.Trim('\"')).FirstOrDefault(), UriKind.RelativeOrAbsolute);
                    var label = pars.Where(t => t.Item1 == "label").Select(t => t.Item2.Trim('\"')).FirstOrDefault();
                       
                    result.Add(new Tag(term,scheme,label));
                }
            }

            return result;
        }

        
       
        public static string BuildCategoryHeader(IEnumerable<Tag> tags)
        {
            var result = new List<string>();
            foreach(var tag in tags)
            {                
                StringBuilder sb = new StringBuilder();

                if (!String.IsNullOrEmpty(tag.Term))
                {
                    if (tag.Term.Contains(",") || tag.Term.Contains(";"))
                        throw new ArgumentException("Found tag containing ',' or ';' - this will produce an inparsable Category header");
                    sb.Append(tag.Term);
                }

                if (!String.IsNullOrEmpty(tag.Label))
                    sb.AppendFormat("; label=\"{0}\"", tag.Label);

                sb.AppendFormat("; scheme=\"{0}\"", tag.Scheme.ToString());
                result.Add(sb.ToString());
            }

            return String.Join(", ", result);
        }

    
    }
}

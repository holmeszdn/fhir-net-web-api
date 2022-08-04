using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System.Linq;
using Task = System.Threading.Tasks.Task;

namespace UnitTestWebApi
{
    [TestClass]
    public class ClosureTableTests
    {
        #region << Test prepare and cleanup >>

        public static void DebugDumpOutputXml(Base fragment)
        {
            if (fragment == null)
                Console.WriteLine("(null)");
            else
            {
                var doc = System.Xml.Linq.XDocument.Parse(new FhirXmlSerializer().SerializeToString(fragment));
                Console.WriteLine(doc.ToString(System.Xml.Linq.SaveOptions.None));
            }
        }
        public static void DebugDumpOutputJson(Base fragment)
        {
            if (fragment == null)
                Console.WriteLine("(null)");
            else
            {
                Console.WriteLine(new FhirJsonSerializer(new SerializerSettings() { Pretty = true }).SerializeToString(fragment));
            }
        }
        #endregion

#if NETCOREAPP3_0_OR_GREATER
        [TestMethod]
        public async Task QuickTestCreatingOntoServerClosureTable()
        {
            // Call the closure operation on the Ontoserver database
            FhirClient terminologyServer = new FhirClient("https://r4.ontoserver.csiro.au/fhir");

            // Initialize the closure table
            var parameters = new Parameters();
            parameters.Add("name", new FhirString("brian_test"));
            DebugDumpOutputXml(parameters);
            var closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
            DebugDumpOutputXml(closureResult);

            // And the concept into the registry
            parameters.Add("name", new FhirString("brian_test"));
            parameters.Add("concept", new Coding("http://loinc.org", "LP415675-0"));
            parameters.Add("concept", new Coding("http://loinc.org", "LP416421-8"));
            parameters.Add("concept", new Coding("http://loinc.org", "29463-7"));
            parameters.Add("concept", new Coding("http://loinc.org", "3141-9"));
            // parameters.Add("version", new FhirString("nominated_version"));
            DebugDumpOutputXml(parameters);
            closureResult = await terminologyServer.WholeSystemOperationAsync("closure", parameters);
            DebugDumpOutputXml(closureResult);
        }
#endif
    }
}

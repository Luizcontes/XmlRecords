using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssXmlRecords {

	public interface IssXmlRecords {

		/// <summary>
		/// Load an XML and fill the RecordList given as argument with Records deserialized data.
		/// </summary>
		/// <param name="ssXml">The XML to deserialize. The top set of nodes must match the definition of the RecordList records</param>
		/// <param name="ssRecordList">RecordList of objects with the expected structure to load from the XML</param>
		/// <param name="ssXmlConfig">An hash of properties given to each record that allow configuring the transformations when reading the xml to import</param>
		/// <param name="ssIgnoreXMLDeclarationAndNS">If the XML contains a declaration node or a namespace, this ate not considered in the root document to prevend tag and structure definition conflicts</param>
		/// <param name="ssAttributePrefix">If the record fields start with this prefix, the deserializer searches its value in node attributes instead of node child elements</param>
		/// <param name="ssDefaultConfig">The defaults for configuring the behaviour of importing</param>
		/// <param name="ssBypassRootRecordListNode">If this attribute is true, the extension ignores a root node &lt;RecordList&gt; and only checks the child nodes of &lt;RecordList&gt;. If false, this root node is not ignored, and considered as part of the Record name</param>
		/// <param name="ssBypassComments">If this parameter is true, the extension ignores the comments</param>
		void MssXmlToRecordList(string ssXml, object ssRecordList, RLRecordXmlConfigRecordList ssXmlConfig, bool ssIgnoreXMLDeclarationAndNS, string ssAttributePrefix, RCDefaultXmlConfigRecord ssDefaultConfig, bool ssBypassRootRecordListNode, bool ssBypassComments);

		/// <summary>
		/// Exports a record to an xml document that matches the hierarchy of the structure
		/// </summary>
		/// <param name="ssRecord">The record to serialize to XML</param>
		/// <param name="ssXmlConfig">An hash of properties given to each record that allow configuring the exact format of export</param>
		/// <param name="ssDefaultConfig">The defaults for configuring the behaviour of exporting</param>
		/// <param name="ssXml"></param>
		void MssRecordToXml(object ssRecord, RLRecordXmlConfigRecordList ssXmlConfig, RCDefaultXmlConfigRecord ssDefaultConfig, out string ssXml);

		/// <summary>
		/// Exports a record list to an xml document that matches the hierarchy of the records underneath
		/// </summary>
		/// <param name="ssRecordList">The record to serialize to XML</param>
		/// <param name="ssXmlConfig">An hash of properties given to each record that allow configuring the exact format of export</param>
		/// <param name="ssDefaultConfig">The defaults for configuring the behaviour of exporting</param>
		/// <param name="ssAddRootNode">If true, the resulting XML will be surrounded by a root node &lt;RecordList&gt;. By default no root node is added.</param>
		/// <param name="ssXml"></param>
		void MssRecordListToXml(object ssRecordList, RLRecordXmlConfigRecordList ssXmlConfig, RCDefaultXmlConfigRecord ssDefaultConfig, bool ssAddRootNode, out string ssXml);

	} // IssXmlRecords

} // OutSystems.NssXmlRecords

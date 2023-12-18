using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssXmlRecords {

	public class ENTestEntRecordEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "1f2ca208-b6a3-4f62-a930-d6583181953b", "dcd4d383-2c6f-4c99-a175-231eb183a10b", "TestEntRecord", "\"dual\""}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "\"dual\""; 
					}
				} catch {
					return "\"dual\""; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENTestEntRecordEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "attr1", "Attr1"
			}
			, { "attr2", "Attr2"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENTestEntRecordEntityConfiguration.GetPhysicalTableName();
		}
	} // ENTestEntRecordEntity

	/// <summary>
	/// Entity <code>ENTestEntRecordEntityRecord</code> that represents the Service Studio entity
	///  <code>TestEntRecord</code> <p> Description: DEPRECATED  Old test entity.</p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("TestEntRecord", "g9PU3G8smUyhdSMesYOhCw", "CKIsH6O2Yk+pMNZYMYGVOw", 0, "\"dual\"", null)]
	[Serializable()]
	public partial struct ENTestEntRecordEntityRecord: ISerializable, ITypedRecord<ENTestEntRecordEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdAttr1 = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*mg0DBO_AR0KQXTSt0+1f3w");
		internal static readonly GlobalObjectKey IdAttr2 = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*lq8cTK82IUqX4VPBBahhKQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Attr1", 50, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Attr1")]
		private string _ssAttr1;
		public string ssAttr1 {
			get {
				return _ssAttr1;
			}
			set {
				if ((_ssAttr1!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssAttr1 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Attr2", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Attr2")]
		private int _ssAttr2;
		public int ssAttr2 {
			get {
				return _ssAttr2;
			}
			set {
				if ((_ssAttr2!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssAttr2 = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENTestEntRecordEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssAttr1 = "";
			_ssAttr2 = 0;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssAttr1 = r.ReadText(index++, "TestEntRecord.Attr1", "");
			ssAttr2 = r.ReadInteger(index++, "TestEntRecord.Attr2", 0);
			ChangedAttributes = new BitArray(2, false);
			OptimizedAttributes = new BitArray(2, false);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(ENTestEntRecordEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENTestEntRecordEntityRecord a, ENTestEntRecordEntityRecord b) {
			if (a.ssAttr1 != b.ssAttr1) return false;
			if (a.ssAttr2 != b.ssAttr2) return false;
			return true;
		}

		public static bool operator != (ENTestEntRecordEntityRecord a, ENTestEntRecordEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENTestEntRecordEntityRecord)) return false;
			return (this == (ENTestEntRecordEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAttr1.GetHashCode()
				^ ssAttr2.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public ENTestEntRecordEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssAttr1 = "";
			_ssAttr2 = 0;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssAttr1", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAttr1' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAttr1 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAttr2", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAttr2' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAttr2 = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENTestEntRecordEntityRecord Duplicate() {
			ENTestEntRecordEntityRecord t;
			t._ssAttr1 = this._ssAttr1;
			t._ssAttr2 = this._ssAttr2;
			t.ChangedAttributes = new BitArray(2);
			t.OptimizedAttributes = new BitArray(2);
			for (int i = 0; i < 2; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attr1")) VarValue.AppendAttribute(recordElem, "Attr1", ssAttr1, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Attr1");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attr2")) VarValue.AppendAttribute(recordElem, "Attr2", ssAttr2, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Attr2");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attr1") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attr1")) variable.Value = ssAttr1; else variable.Optimized = true;
			} else if (head == "attr2") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attr2")) variable.Value = ssAttr2; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdAttr1)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdAttr2)) {
				return ChangedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdAttr1)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdAttr2)) {
				return OptimizedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAttr1) {
				return ssAttr1;
			} else if (key == IdAttr2) {
				return ssAttr2;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(2);
			OptimizedAttributes = new BitArray(2);
			if (other == null) return;
			ssAttr1 = (string) other.AttributeGet(IdAttr1);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdAttr1);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAttr1);
			ssAttr2 = (int) other.AttributeGet(IdAttr2);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdAttr2);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdAttr2);
		}
		public bool IsDefault() {
			ENTestEntRecordEntityRecord defaultStruct = new ENTestEntRecordEntityRecord(null);
			if (this.ssAttr1 != defaultStruct.ssAttr1) return false;
			if (this.ssAttr2 != defaultStruct.ssAttr2) return false;
			return true;
		}
	} // ENTestEntRecordEntityRecord

} // OutSystems.NssXmlRecords

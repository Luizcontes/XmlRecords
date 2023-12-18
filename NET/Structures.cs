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

	/// <summary>
	/// Structure <code>STTestStructure</code> that represents the Service Studio structure
	///  <code>Test</code> <p> Description: Structure used for unit testing within the extension. Avoi
	/// d usage.</p>
	/// </summary>
	[Serializable()]
	public partial struct STTestStructure: ISerializable, ITypedRecord<STTestStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdAttribute1 = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*EaIE6Gaga0mN242i3ghgew");
		internal static readonly GlobalObjectKey IdAttribute2 = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*BBkzW1Q6+km2bFoYgDePVg");
		internal static readonly GlobalObjectKey IdAttribute3 = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*efuOBg+tbkSxrH5IZjzyOg");
		internal static readonly GlobalObjectKey IdAttribute4 = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*zpmgfG6Mb0SwBA34nKPQzw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Attribute1")]
		public string ssAttribute1;

		[System.Xml.Serialization.XmlElement("Attribute2")]
		public string ssAttribute2;

		[System.Xml.Serialization.XmlElement("Attribute3")]
		public string ssAttribute3;

		[System.Xml.Serialization.XmlElement("Attribute4")]
		public string ssAttribute4;


		public BitArray OptimizedAttributes;

		public STTestStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssAttribute1 = "";
			ssAttribute2 = "";
			ssAttribute3 = "";
			ssAttribute4 = "";
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
			ssAttribute1 = r.ReadText(index++, "Test.Attribute1", "");
			ssAttribute2 = r.ReadText(index++, "Test.Attribute2", "");
			ssAttribute3 = r.ReadText(index++, "Test.Attribute3", "");
			ssAttribute4 = r.ReadText(index++, "Test.Attribute4", "");
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
		public void ReadIM(STTestStructure r) {
			this = r;
		}


		public static bool operator == (STTestStructure a, STTestStructure b) {
			if (a.ssAttribute1 != b.ssAttribute1) return false;
			if (a.ssAttribute2 != b.ssAttribute2) return false;
			if (a.ssAttribute3 != b.ssAttribute3) return false;
			if (a.ssAttribute4 != b.ssAttribute4) return false;
			return true;
		}

		public static bool operator != (STTestStructure a, STTestStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STTestStructure)) return false;
			return (this == (STTestStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAttribute1.GetHashCode()
				^ ssAttribute2.GetHashCode()
				^ ssAttribute3.GetHashCode()
				^ ssAttribute4.GetHashCode()
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

		public STTestStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssAttribute1 = "";
			ssAttribute2 = "";
			ssAttribute3 = "";
			ssAttribute4 = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssAttribute1", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttribute1' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttribute1 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttribute2", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttribute2' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttribute2 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttribute3", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttribute3' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttribute3 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttribute4", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttribute4' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttribute4 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STTestStructure Duplicate() {
			STTestStructure t;
			t.ssAttribute1 = this.ssAttribute1;
			t.ssAttribute2 = this.ssAttribute2;
			t.ssAttribute3 = this.ssAttribute3;
			t.ssAttribute4 = this.ssAttribute4;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attribute1")) VarValue.AppendAttribute(recordElem, "Attribute1", ssAttribute1, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Attribute1");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attribute2")) VarValue.AppendAttribute(recordElem, "Attribute2", ssAttribute2, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Attribute2");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attribute3")) VarValue.AppendAttribute(recordElem, "Attribute3", ssAttribute3, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Attribute3");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Attribute4")) VarValue.AppendAttribute(recordElem, "Attribute4", ssAttribute4, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Attribute4");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attribute1") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attribute1")) variable.Value = ssAttribute1; else variable.Optimized = true;
			} else if (head == "attribute2") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attribute2")) variable.Value = ssAttribute2; else variable.Optimized = true;
			} else if (head == "attribute3") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attribute3")) variable.Value = ssAttribute3; else variable.Optimized = true;
			} else if (head == "attribute4") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attribute4")) variable.Value = ssAttribute4; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAttribute1) {
				return ssAttribute1;
			} else if (key == IdAttribute2) {
				return ssAttribute2;
			} else if (key == IdAttribute3) {
				return ssAttribute3;
			} else if (key == IdAttribute4) {
				return ssAttribute4;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssAttribute1 = (string) other.AttributeGet(IdAttribute1);
			ssAttribute2 = (string) other.AttributeGet(IdAttribute2);
			ssAttribute3 = (string) other.AttributeGet(IdAttribute3);
			ssAttribute4 = (string) other.AttributeGet(IdAttribute4);
		}
		public bool IsDefault() {
			STTestStructure defaultStruct = new STTestStructure(null);
			if (this.ssAttribute1 != defaultStruct.ssAttribute1) return false;
			if (this.ssAttribute2 != defaultStruct.ssAttribute2) return false;
			if (this.ssAttribute3 != defaultStruct.ssAttribute3) return false;
			if (this.ssAttribute4 != defaultStruct.ssAttribute4) return false;
			return true;
		}
	} // STTestStructure

	/// <summary>
	/// Structure <code>STTestHierarchicalStructure</code> that represents the Service Studio structure
	///  <code>TestHierarchical</code> <p> Description: Structure used for unit testing within th
	/// e extension. Avoid usage.</p>
	/// </summary>
	[Serializable()]
	public partial struct STTestHierarchicalStructure: ISerializable, ITypedRecord<STTestHierarchicalStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdaString = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*Phyxt6XxhkCMIPnBsm_82Q");
		internal static readonly GlobalObjectKey IdaInt = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*ZuY6Mc2ZwEu_5SsFJAtZ4w");
		internal static readonly GlobalObjectKey IdaDecimal = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*5dwlSCx6LE6l2xUqDek9Ew");
		internal static readonly GlobalObjectKey IdaBoolean = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*RM7XXXbCO0KBBukz47+Ojg");
		internal static readonly GlobalObjectKey IdaDate = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*UNF048uNGkeM_uvliql6fQ");
		internal static readonly GlobalObjectKey IdaDateTime = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*eRXcEkruS0ubI65HCn3F1A");
		internal static readonly GlobalObjectKey IdaTime = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*F+Fgpd6rx0GRDzO87Qi4Rw");
		internal static readonly GlobalObjectKey IdaRecordList = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*mlbnoFjVfES_pLdkGF7PRg");
		internal static readonly GlobalObjectKey IdaRecord = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*vfxgto0bBkCE_VgqZRDlwQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("aString")]
		public string ssaString;

		[System.Xml.Serialization.XmlElement("aInt")]
		public int ssaInt;

		[System.Xml.Serialization.XmlElement("aDecimal")]
		public decimal ssaDecimal;

		[System.Xml.Serialization.XmlElement("aBoolean")]
		public bool ssaBoolean;

		[System.Xml.Serialization.XmlElement("aDate")]
		public DateTime ssaDate;

		[System.Xml.Serialization.XmlElement("aDateTime")]
		public DateTime ssaDateTime;

		[System.Xml.Serialization.XmlElement("aTime")]
		public DateTime ssaTime;

		[System.Xml.Serialization.XmlElement("aRecordList")]
		public RLTestRecordList ssaRecordList;

		[System.Xml.Serialization.XmlElement("aRecord")]
		public RCTestRecord ssaRecord;


		public BitArray OptimizedAttributes;

		public STTestHierarchicalStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssaString = "";
			ssaInt = 0;
			ssaDecimal = 0.0M;
			ssaBoolean = false;
			ssaDate = new DateTime(1900, 1, 1, 0, 0, 0);
			ssaDateTime = new DateTime(1900, 1, 1, 0, 0, 0);
			ssaTime = new DateTime(1900, 1, 1, 0, 0, 0);
			ssaRecordList = new RLTestRecordList();
			ssaRecord = new RCTestRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssaRecord.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssaString = r.ReadText(index++, "TestHierarchical.aString", "");
			ssaInt = r.ReadInteger(index++, "TestHierarchical.aInt", 0);
			ssaDecimal = r.ReadDecimal(index++, "TestHierarchical.aDecimal", 0.0M);
			ssaBoolean = r.ReadBoolean(index++, "TestHierarchical.aBoolean", false);
			ssaDate = r.ReadDate(index++, "TestHierarchical.aDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssaDateTime = r.ReadDateTime(index++, "TestHierarchical.aDateTime", new DateTime(1900, 1, 1, 0, 0, 0));
			ssaTime = r.ReadTime(index++, "TestHierarchical.aTime", new DateTime(1900, 1, 1, 0, 0, 0));
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
		public void ReadIM(STTestHierarchicalStructure r) {
			this = r;
		}


		public static bool operator == (STTestHierarchicalStructure a, STTestHierarchicalStructure b) {
			if (a.ssaString != b.ssaString) return false;
			if (a.ssaInt != b.ssaInt) return false;
			if (a.ssaDecimal != b.ssaDecimal) return false;
			if (a.ssaBoolean != b.ssaBoolean) return false;
			if (a.ssaDate != b.ssaDate) return false;
			if (a.ssaDateTime != b.ssaDateTime) return false;
			if (a.ssaTime != b.ssaTime) return false;
			if (a.ssaRecordList != b.ssaRecordList) return false;
			if (a.ssaRecord != b.ssaRecord) return false;
			return true;
		}

		public static bool operator != (STTestHierarchicalStructure a, STTestHierarchicalStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STTestHierarchicalStructure)) return false;
			return (this == (STTestHierarchicalStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssaString.GetHashCode()
				^ ssaInt.GetHashCode()
				^ ssaDecimal.GetHashCode()
				^ ssaBoolean.GetHashCode()
				^ ssaDate.GetHashCode()
				^ ssaDateTime.GetHashCode()
				^ ssaTime.GetHashCode()
				^ ssaRecordList.GetHashCode()
				^ ssaRecord.GetHashCode()
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

		public STTestHierarchicalStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssaString = "";
			ssaInt = 0;
			ssaDecimal = 0.0M;
			ssaBoolean = false;
			ssaDate = new DateTime(1900, 1, 1, 0, 0, 0);
			ssaDateTime = new DateTime(1900, 1, 1, 0, 0, 0);
			ssaTime = new DateTime(1900, 1, 1, 0, 0, 0);
			ssaRecordList = new RLTestRecordList();
			ssaRecord = new RCTestRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssaString", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaString' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaString = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaInt", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaInt' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaInt = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaDecimal", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaDecimal' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaDecimal = (decimal) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaBoolean", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaBoolean' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaBoolean = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaDateTime", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaDateTime' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaDateTime = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaTime", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaTime' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaTime = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaRecordList", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaRecordList' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaRecordList = (RLTestRecordList) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssaRecord", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssaRecord' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssaRecord = (RCTestRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssaRecordList.RecursiveReset();
			ssaRecord.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssaRecordList.InternalRecursiveSave();
			ssaRecord.InternalRecursiveSave();
		}


		public STTestHierarchicalStructure Duplicate() {
			STTestHierarchicalStructure t;
			t.ssaString = this.ssaString;
			t.ssaInt = this.ssaInt;
			t.ssaDecimal = this.ssaDecimal;
			t.ssaBoolean = this.ssaBoolean;
			t.ssaDate = this.ssaDate;
			t.ssaDateTime = this.ssaDateTime;
			t.ssaTime = this.ssaTime;
			t.ssaRecordList = (RLTestRecordList) this.ssaRecordList.Duplicate();
			t.ssaRecord = (RCTestRecord) this.ssaRecord.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aString")) VarValue.AppendAttribute(recordElem, "aString", ssaString, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "aString");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aInt")) VarValue.AppendAttribute(recordElem, "aInt", ssaInt, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "aInt");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aDecimal")) VarValue.AppendAttribute(recordElem, "aDecimal", ssaDecimal, detailLevel, TypeKind.Decimal); else VarValue.AppendOptimizedAttribute(recordElem, "aDecimal");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aBoolean")) VarValue.AppendAttribute(recordElem, "aBoolean", ssaBoolean, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "aBoolean");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aDate")) VarValue.AppendAttribute(recordElem, "aDate", ssaDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "aDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aDateTime")) VarValue.AppendAttribute(recordElem, "aDateTime", ssaDateTime, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "aDateTime");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".aTime")) VarValue.AppendAttribute(recordElem, "aTime", ssaTime, detailLevel, TypeKind.Time); else VarValue.AppendOptimizedAttribute(recordElem, "aTime");
				ssaRecordList.ToXml(this, recordElem, "aRecordList", detailLevel - 1);
				ssaRecord.ToXml(this, recordElem, "aRecord", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "astring") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aString")) variable.Value = ssaString; else variable.Optimized = true;
			} else if (head == "aint") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aInt")) variable.Value = ssaInt; else variable.Optimized = true;
			} else if (head == "adecimal") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aDecimal")) variable.Value = ssaDecimal; else variable.Optimized = true;
			} else if (head == "aboolean") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aBoolean")) variable.Value = ssaBoolean; else variable.Optimized = true;
			} else if (head == "adate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aDate")) variable.Value = ssaDate; else variable.Optimized = true;
			} else if (head == "adatetime") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aDateTime")) variable.Value = ssaDateTime; else variable.Optimized = true;
			} else if (head == "atime") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aTime")) variable.Value = ssaTime; else variable.Optimized = true;
			} else if (head == "arecordlist") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aRecordList")) variable.Value = ssaRecordList; else variable.Optimized = true;
				variable.SetFieldName("arecordlist");
			} else if (head == "arecord") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".aRecord")) variable.Value = ssaRecord; else variable.Optimized = true;
				variable.SetFieldName("arecord");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdaString) {
				return ssaString;
			} else if (key == IdaInt) {
				return ssaInt;
			} else if (key == IdaDecimal) {
				return ssaDecimal;
			} else if (key == IdaBoolean) {
				return ssaBoolean;
			} else if (key == IdaDate) {
				return ssaDate;
			} else if (key == IdaDateTime) {
				return ssaDateTime;
			} else if (key == IdaTime) {
				return ssaTime;
			} else if (key == IdaRecordList) {
				return ssaRecordList;
			} else if (key == IdaRecord) {
				return ssaRecord;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssaString = (string) other.AttributeGet(IdaString);
			ssaInt = (int) other.AttributeGet(IdaInt);
			ssaDecimal = (decimal) other.AttributeGet(IdaDecimal);
			ssaBoolean = (bool) other.AttributeGet(IdaBoolean);
			ssaDate = (DateTime) other.AttributeGet(IdaDate);
			ssaDateTime = (DateTime) other.AttributeGet(IdaDateTime);
			ssaTime = (DateTime) other.AttributeGet(IdaTime);
			ssaRecordList = new RLTestRecordList();
			ssaRecordList.FillFromOther((IOSList) other.AttributeGet(IdaRecordList));
			ssaRecord.FillFromOther((IRecord) other.AttributeGet(IdaRecord));
		}
		public bool IsDefault() {
			STTestHierarchicalStructure defaultStruct = new STTestHierarchicalStructure(null);
			if (this.ssaString != defaultStruct.ssaString) return false;
			if (this.ssaInt != defaultStruct.ssaInt) return false;
			if (this.ssaDecimal != defaultStruct.ssaDecimal) return false;
			if (this.ssaBoolean != defaultStruct.ssaBoolean) return false;
			if (this.ssaDate != defaultStruct.ssaDate) return false;
			if (this.ssaDateTime != defaultStruct.ssaDateTime) return false;
			if (this.ssaTime != defaultStruct.ssaTime) return false;
			if (this.ssaRecordList != null && this.ssaRecordList.Length != 0) return false;
			if (this.ssaRecord != defaultStruct.ssaRecord) return false;
			return true;
		}
	} // STTestHierarchicalStructure

	/// <summary>
	/// Structure <code>STRecordXmlConfigStructure</code> that represents the Service Studio structure
	///  <code>RecordXmlConfig</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STRecordXmlConfigStructure: ISerializable, ITypedRecord<STRecordXmlConfigStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdRecordName = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*G0SiRW3zG0O_kTmZY3fq8A");
		internal static readonly GlobalObjectKey IdAttributesConfig = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*wJfuLLLmdE26Jt55Mznfsg");
		internal static readonly GlobalObjectKey IdNamespace = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*+aaeZSkIp0q2Hjka_ufp3A");
		internal static readonly GlobalObjectKey IdEffectiveName = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*UbonTCamyka6th7PNaKKUg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("RecordName")]
		public string ssRecordName;

		[System.Xml.Serialization.XmlElement("AttributesConfig")]
		public RLAttributeXmlConfigRecordList ssAttributesConfig;

		[System.Xml.Serialization.XmlElement("Namespace")]
		public string ssNamespace;

		[System.Xml.Serialization.XmlElement("EffectiveName")]
		public string ssEffectiveName;


		public BitArray OptimizedAttributes;

		public STRecordXmlConfigStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssRecordName = "";
			ssAttributesConfig = new RLAttributeXmlConfigRecordList();
			ssNamespace = "";
			ssEffectiveName = "";
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
			ssRecordName = r.ReadText(index++, "RecordXmlConfig.RecordName", "");
			ssNamespace = r.ReadText(index++, "RecordXmlConfig.Namespace", "");
			ssEffectiveName = r.ReadText(index++, "RecordXmlConfig.EffectiveName", "");
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
		public void ReadIM(STRecordXmlConfigStructure r) {
			this = r;
		}


		public static bool operator == (STRecordXmlConfigStructure a, STRecordXmlConfigStructure b) {
			if (a.ssRecordName != b.ssRecordName) return false;
			if (a.ssAttributesConfig != b.ssAttributesConfig) return false;
			if (a.ssNamespace != b.ssNamespace) return false;
			if (a.ssEffectiveName != b.ssEffectiveName) return false;
			return true;
		}

		public static bool operator != (STRecordXmlConfigStructure a, STRecordXmlConfigStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STRecordXmlConfigStructure)) return false;
			return (this == (STRecordXmlConfigStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssRecordName.GetHashCode()
				^ ssAttributesConfig.GetHashCode()
				^ ssNamespace.GetHashCode()
				^ ssEffectiveName.GetHashCode()
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

		public STRecordXmlConfigStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssRecordName = "";
			ssAttributesConfig = new RLAttributeXmlConfigRecordList();
			ssNamespace = "";
			ssEffectiveName = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssRecordName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssRecordName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssRecordName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttributesConfig", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttributesConfig' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttributesConfig = (RLAttributeXmlConfigRecordList) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssNamespace", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssNamespace' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssNamespace = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssEffectiveName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEffectiveName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEffectiveName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssAttributesConfig.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssAttributesConfig.InternalRecursiveSave();
		}


		public STRecordXmlConfigStructure Duplicate() {
			STRecordXmlConfigStructure t;
			t.ssRecordName = this.ssRecordName;
			t.ssAttributesConfig = (RLAttributeXmlConfigRecordList) this.ssAttributesConfig.Duplicate();
			t.ssNamespace = this.ssNamespace;
			t.ssEffectiveName = this.ssEffectiveName;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RecordName")) VarValue.AppendAttribute(recordElem, "RecordName", ssRecordName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "RecordName");
				ssAttributesConfig.ToXml(this, recordElem, "AttributesConfig", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Namespace")) VarValue.AppendAttribute(recordElem, "Namespace", ssNamespace, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Namespace");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EffectiveName")) VarValue.AppendAttribute(recordElem, "EffectiveName", ssEffectiveName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "EffectiveName");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "recordname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordName")) variable.Value = ssRecordName; else variable.Optimized = true;
			} else if (head == "attributesconfig") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AttributesConfig")) variable.Value = ssAttributesConfig; else variable.Optimized = true;
				variable.SetFieldName("attributesconfig");
			} else if (head == "namespace") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Namespace")) variable.Value = ssNamespace; else variable.Optimized = true;
			} else if (head == "effectivename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EffectiveName")) variable.Value = ssEffectiveName; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdRecordName) {
				return ssRecordName;
			} else if (key == IdAttributesConfig) {
				return ssAttributesConfig;
			} else if (key == IdNamespace) {
				return ssNamespace;
			} else if (key == IdEffectiveName) {
				return ssEffectiveName;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssRecordName = (string) other.AttributeGet(IdRecordName);
			ssAttributesConfig = new RLAttributeXmlConfigRecordList();
			ssAttributesConfig.FillFromOther((IOSList) other.AttributeGet(IdAttributesConfig));
			ssNamespace = (string) other.AttributeGet(IdNamespace);
			ssEffectiveName = (string) other.AttributeGet(IdEffectiveName);
		}
		public bool IsDefault() {
			STRecordXmlConfigStructure defaultStruct = new STRecordXmlConfigStructure(null);
			if (this.ssRecordName != defaultStruct.ssRecordName) return false;
			if (this.ssAttributesConfig != null && this.ssAttributesConfig.Length != 0) return false;
			if (this.ssNamespace != defaultStruct.ssNamespace) return false;
			if (this.ssEffectiveName != defaultStruct.ssEffectiveName) return false;
			return true;
		}
	} // STRecordXmlConfigStructure

	/// <summary>
	/// Structure <code>STAttributeXmlConfigStructure</code> that represents the Service Studio structure
	///  <code>AttributeXmlConfig</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAttributeXmlConfigStructure: ISerializable, ITypedRecord<STAttributeXmlConfigStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*OvRVilE6d0iUFy0EM6M7zQ");
		internal static readonly GlobalObjectKey IdAttributeName = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*O8+LpFht50CHREf22TzPzw");
		internal static readonly GlobalObjectKey IdExcludeIfNull = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*7ZNukibAekW_z0YD3d6z3Q");
		internal static readonly GlobalObjectKey IdNullableValue = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*v838Tf_fA0aGZUJPf5ngQw");
		internal static readonly GlobalObjectKey IdRecordListMode = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*m1u8Iy_0EEWsGTYDCxeIeQ");
		internal static readonly GlobalObjectKey IdRecordMode = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*QuD33fMgaEuGwTt9SlVKhA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("AttributeName")]
		public string ssAttributeName;

		[System.Xml.Serialization.XmlElement("ExcludeIfNull")]
		public bool ssExcludeIfNull;

		[System.Xml.Serialization.XmlElement("NullableValue")]
		public string ssNullableValue;

		[System.Xml.Serialization.XmlElement("RecordListMode")]
		public string ssRecordListMode;

		[System.Xml.Serialization.XmlElement("RecordMode")]
		public string ssRecordMode;


		public BitArray OptimizedAttributes;

		public STAttributeXmlConfigStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssName = "";
			ssAttributeName = "";
			ssExcludeIfNull = true;
			ssNullableValue = "";
			ssRecordListMode = "C";
			ssRecordMode = "S";
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
			ssName = r.ReadText(index++, "AttributeXmlConfig.Name", "");
			ssAttributeName = r.ReadText(index++, "AttributeXmlConfig.AttributeName", "");
			ssExcludeIfNull = r.ReadBoolean(index++, "AttributeXmlConfig.ExcludeIfNull", false);
			ssNullableValue = r.ReadText(index++, "AttributeXmlConfig.NullableValue", "");
			ssRecordListMode = r.ReadText(index++, "AttributeXmlConfig.RecordListMode", "");
			ssRecordMode = r.ReadText(index++, "AttributeXmlConfig.RecordMode", "");
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
		public void ReadIM(STAttributeXmlConfigStructure r) {
			this = r;
		}


		public static bool operator == (STAttributeXmlConfigStructure a, STAttributeXmlConfigStructure b) {
			if (a.ssName != b.ssName) return false;
			if (a.ssAttributeName != b.ssAttributeName) return false;
			if (a.ssExcludeIfNull != b.ssExcludeIfNull) return false;
			if (a.ssNullableValue != b.ssNullableValue) return false;
			if (a.ssRecordListMode != b.ssRecordListMode) return false;
			if (a.ssRecordMode != b.ssRecordMode) return false;
			return true;
		}

		public static bool operator != (STAttributeXmlConfigStructure a, STAttributeXmlConfigStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAttributeXmlConfigStructure)) return false;
			return (this == (STAttributeXmlConfigStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssName.GetHashCode()
				^ ssAttributeName.GetHashCode()
				^ ssExcludeIfNull.GetHashCode()
				^ ssNullableValue.GetHashCode()
				^ ssRecordListMode.GetHashCode()
				^ ssRecordMode.GetHashCode()
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

		public STAttributeXmlConfigStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssName = "";
			ssAttributeName = "";
			ssExcludeIfNull = true;
			ssNullableValue = "";
			ssRecordListMode = "C";
			ssRecordMode = "S";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttributeName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttributeName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttributeName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssExcludeIfNull", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssExcludeIfNull' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssExcludeIfNull = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssNullableValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssNullableValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssNullableValue = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssRecordListMode", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssRecordListMode' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssRecordListMode = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssRecordMode", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssRecordMode' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssRecordMode = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAttributeXmlConfigStructure Duplicate() {
			STAttributeXmlConfigStructure t;
			t.ssName = this.ssName;
			t.ssAttributeName = this.ssAttributeName;
			t.ssExcludeIfNull = this.ssExcludeIfNull;
			t.ssNullableValue = this.ssNullableValue;
			t.ssRecordListMode = this.ssRecordListMode;
			t.ssRecordMode = this.ssRecordMode;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AttributeName")) VarValue.AppendAttribute(recordElem, "AttributeName", ssAttributeName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AttributeName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ExcludeIfNull")) VarValue.AppendAttribute(recordElem, "ExcludeIfNull", ssExcludeIfNull, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "ExcludeIfNull");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".NullableValue")) VarValue.AppendAttribute(recordElem, "NullableValue", ssNullableValue, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "NullableValue");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RecordListMode")) VarValue.AppendAttribute(recordElem, "RecordListMode", ssRecordListMode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "RecordListMode");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RecordMode")) VarValue.AppendAttribute(recordElem, "RecordMode", ssRecordMode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "RecordMode");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "attributename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AttributeName")) variable.Value = ssAttributeName; else variable.Optimized = true;
			} else if (head == "excludeifnull") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcludeIfNull")) variable.Value = ssExcludeIfNull; else variable.Optimized = true;
			} else if (head == "nullablevalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NullableValue")) variable.Value = ssNullableValue; else variable.Optimized = true;
			} else if (head == "recordlistmode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordListMode")) variable.Value = ssRecordListMode; else variable.Optimized = true;
			} else if (head == "recordmode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordMode")) variable.Value = ssRecordMode; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdName) {
				return ssName;
			} else if (key == IdAttributeName) {
				return ssAttributeName;
			} else if (key == IdExcludeIfNull) {
				return ssExcludeIfNull;
			} else if (key == IdNullableValue) {
				return ssNullableValue;
			} else if (key == IdRecordListMode) {
				return ssRecordListMode;
			} else if (key == IdRecordMode) {
				return ssRecordMode;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssName = (string) other.AttributeGet(IdName);
			ssAttributeName = (string) other.AttributeGet(IdAttributeName);
			ssExcludeIfNull = (bool) other.AttributeGet(IdExcludeIfNull);
			ssNullableValue = (string) other.AttributeGet(IdNullableValue);
			ssRecordListMode = (string) other.AttributeGet(IdRecordListMode);
			ssRecordMode = (string) other.AttributeGet(IdRecordMode);
		}
		public bool IsDefault() {
			STAttributeXmlConfigStructure defaultStruct = new STAttributeXmlConfigStructure(null);
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssAttributeName != defaultStruct.ssAttributeName) return false;
			if (this.ssExcludeIfNull != defaultStruct.ssExcludeIfNull) return false;
			if (this.ssNullableValue != defaultStruct.ssNullableValue) return false;
			if (this.ssRecordListMode != defaultStruct.ssRecordListMode) return false;
			if (this.ssRecordMode != defaultStruct.ssRecordMode) return false;
			return true;
		}
	} // STAttributeXmlConfigStructure

	/// <summary>
	/// Structure <code>STDefaultXmlConfigStructure</code> that represents the Service Studio structure
	///  <code>DefaultXmlConfig</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STDefaultXmlConfigStructure: ISerializable, ITypedRecord<STDefaultXmlConfigStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdExcludeIfNull = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*7kHPpsafxEiAdQThyw7Cng");
		internal static readonly GlobalObjectKey IdRecordListMode = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*41YY+yjgb02CWRYxdtecJg");
		internal static readonly GlobalObjectKey IdRecordMode = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*pWUn_JVKvkGoTCf6s7cz5A");
		internal static readonly GlobalObjectKey IdAttributePrefix = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*IFTb0WKaAkSKiLg+En0f2Q");
		internal static readonly GlobalObjectKey IdContentPrefix = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*QGSCzWoeyEqYm2KaKkTK4A");
		internal static readonly GlobalObjectKey IdXmlDeclaration = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*QgaoB1WP5UmNPBFGniVFVQ");
		internal static readonly GlobalObjectKey IdTypeDecimalCulture = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*H3dwN_Q3bEK06ZPEli1ihQ");
		internal static readonly GlobalObjectKey IdTypeDateTimeFormat = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*wroxmZp6lUGdWXy1t8uhIQ");
		internal static readonly GlobalObjectKey IdTypeDateFormat = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*G3Fi6XF_JUOLW5yxN3rcWg");
		internal static readonly GlobalObjectKey IdTypeTimeFormat = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*EIgnT1_jKk6xf4_HpeoTCQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ExcludeIfNull")]
		public bool ssExcludeIfNull;

		[System.Xml.Serialization.XmlElement("RecordListMode")]
		public string ssRecordListMode;

		[System.Xml.Serialization.XmlElement("RecordMode")]
		public string ssRecordMode;

		[System.Xml.Serialization.XmlElement("AttributePrefix")]
		public string ssAttributePrefix;

		[System.Xml.Serialization.XmlElement("ContentPrefix")]
		public string ssContentPrefix;

		[System.Xml.Serialization.XmlElement("XmlDeclaration")]
		public RCXmlDeclarationRecord ssXmlDeclaration;

		[System.Xml.Serialization.XmlElement("TypeDecimalCulture")]
		public string ssTypeDecimalCulture;

		[System.Xml.Serialization.XmlElement("TypeDateTimeFormat")]
		public string ssTypeDateTimeFormat;

		[System.Xml.Serialization.XmlElement("TypeDateFormat")]
		public string ssTypeDateFormat;

		[System.Xml.Serialization.XmlElement("TypeTimeFormat")]
		public string ssTypeTimeFormat;


		public BitArray OptimizedAttributes;

		public STDefaultXmlConfigStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssExcludeIfNull = true;
			ssRecordListMode = "C";
			ssRecordMode = "S";
			ssAttributePrefix = "Attr_";
			ssContentPrefix = "Cont_";
			ssXmlDeclaration = new RCXmlDeclarationRecord(null);
			ssTypeDecimalCulture = "";
			ssTypeDateTimeFormat = "";
			ssTypeDateFormat = "";
			ssTypeTimeFormat = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssXmlDeclaration.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssExcludeIfNull = r.ReadBoolean(index++, "DefaultXmlConfig.ExcludeIfNull", false);
			ssRecordListMode = r.ReadText(index++, "DefaultXmlConfig.RecordListMode", "");
			ssRecordMode = r.ReadText(index++, "DefaultXmlConfig.RecordMode", "");
			ssAttributePrefix = r.ReadText(index++, "DefaultXmlConfig.AttributePrefix", "");
			ssContentPrefix = r.ReadText(index++, "DefaultXmlConfig.ContentPrefix", "");
			ssTypeDecimalCulture = r.ReadText(index++, "DefaultXmlConfig.TypeDecimalCulture", "");
			ssTypeDateTimeFormat = r.ReadText(index++, "DefaultXmlConfig.TypeDateTimeFormat", "");
			ssTypeDateFormat = r.ReadText(index++, "DefaultXmlConfig.TypeDateFormat", "");
			ssTypeTimeFormat = r.ReadText(index++, "DefaultXmlConfig.TypeTimeFormat", "");
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
		public void ReadIM(STDefaultXmlConfigStructure r) {
			this = r;
		}


		public static bool operator == (STDefaultXmlConfigStructure a, STDefaultXmlConfigStructure b) {
			if (a.ssExcludeIfNull != b.ssExcludeIfNull) return false;
			if (a.ssRecordListMode != b.ssRecordListMode) return false;
			if (a.ssRecordMode != b.ssRecordMode) return false;
			if (a.ssAttributePrefix != b.ssAttributePrefix) return false;
			if (a.ssContentPrefix != b.ssContentPrefix) return false;
			if (a.ssXmlDeclaration != b.ssXmlDeclaration) return false;
			if (a.ssTypeDecimalCulture != b.ssTypeDecimalCulture) return false;
			if (a.ssTypeDateTimeFormat != b.ssTypeDateTimeFormat) return false;
			if (a.ssTypeDateFormat != b.ssTypeDateFormat) return false;
			if (a.ssTypeTimeFormat != b.ssTypeTimeFormat) return false;
			return true;
		}

		public static bool operator != (STDefaultXmlConfigStructure a, STDefaultXmlConfigStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STDefaultXmlConfigStructure)) return false;
			return (this == (STDefaultXmlConfigStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssExcludeIfNull.GetHashCode()
				^ ssRecordListMode.GetHashCode()
				^ ssRecordMode.GetHashCode()
				^ ssAttributePrefix.GetHashCode()
				^ ssContentPrefix.GetHashCode()
				^ ssXmlDeclaration.GetHashCode()
				^ ssTypeDecimalCulture.GetHashCode()
				^ ssTypeDateTimeFormat.GetHashCode()
				^ ssTypeDateFormat.GetHashCode()
				^ ssTypeTimeFormat.GetHashCode()
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

		public STDefaultXmlConfigStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssExcludeIfNull = true;
			ssRecordListMode = "C";
			ssRecordMode = "S";
			ssAttributePrefix = "Attr_";
			ssContentPrefix = "Cont_";
			ssXmlDeclaration = new RCXmlDeclarationRecord(null);
			ssTypeDecimalCulture = "";
			ssTypeDateTimeFormat = "";
			ssTypeDateFormat = "";
			ssTypeTimeFormat = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssExcludeIfNull", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssExcludeIfNull' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssExcludeIfNull = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssRecordListMode", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssRecordListMode' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssRecordListMode = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssRecordMode", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssRecordMode' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssRecordMode = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttributePrefix", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttributePrefix' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttributePrefix = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssContentPrefix", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssContentPrefix' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssContentPrefix = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssXmlDeclaration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssXmlDeclaration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssXmlDeclaration = (RCXmlDeclarationRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTypeDecimalCulture", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTypeDecimalCulture' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTypeDecimalCulture = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTypeDateTimeFormat", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTypeDateTimeFormat' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTypeDateTimeFormat = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTypeDateFormat", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTypeDateFormat' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTypeDateFormat = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTypeTimeFormat", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTypeTimeFormat' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTypeTimeFormat = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssXmlDeclaration.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssXmlDeclaration.InternalRecursiveSave();
		}


		public STDefaultXmlConfigStructure Duplicate() {
			STDefaultXmlConfigStructure t;
			t.ssExcludeIfNull = this.ssExcludeIfNull;
			t.ssRecordListMode = this.ssRecordListMode;
			t.ssRecordMode = this.ssRecordMode;
			t.ssAttributePrefix = this.ssAttributePrefix;
			t.ssContentPrefix = this.ssContentPrefix;
			t.ssXmlDeclaration = (RCXmlDeclarationRecord) this.ssXmlDeclaration.Duplicate();
			t.ssTypeDecimalCulture = this.ssTypeDecimalCulture;
			t.ssTypeDateTimeFormat = this.ssTypeDateTimeFormat;
			t.ssTypeDateFormat = this.ssTypeDateFormat;
			t.ssTypeTimeFormat = this.ssTypeTimeFormat;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ExcludeIfNull")) VarValue.AppendAttribute(recordElem, "ExcludeIfNull", ssExcludeIfNull, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "ExcludeIfNull");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RecordListMode")) VarValue.AppendAttribute(recordElem, "RecordListMode", ssRecordListMode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "RecordListMode");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".RecordMode")) VarValue.AppendAttribute(recordElem, "RecordMode", ssRecordMode, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "RecordMode");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AttributePrefix")) VarValue.AppendAttribute(recordElem, "AttributePrefix", ssAttributePrefix, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AttributePrefix");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContentPrefix")) VarValue.AppendAttribute(recordElem, "ContentPrefix", ssContentPrefix, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "ContentPrefix");
				ssXmlDeclaration.ToXml(this, recordElem, "XmlDeclaration", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TypeDecimalCulture")) VarValue.AppendAttribute(recordElem, "TypeDecimalCulture", ssTypeDecimalCulture, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "TypeDecimalCulture");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TypeDateTimeFormat")) VarValue.AppendAttribute(recordElem, "TypeDateTimeFormat", ssTypeDateTimeFormat, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "TypeDateTimeFormat");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TypeDateFormat")) VarValue.AppendAttribute(recordElem, "TypeDateFormat", ssTypeDateFormat, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "TypeDateFormat");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TypeTimeFormat")) VarValue.AppendAttribute(recordElem, "TypeTimeFormat", ssTypeTimeFormat, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "TypeTimeFormat");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "excludeifnull") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcludeIfNull")) variable.Value = ssExcludeIfNull; else variable.Optimized = true;
			} else if (head == "recordlistmode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordListMode")) variable.Value = ssRecordListMode; else variable.Optimized = true;
			} else if (head == "recordmode") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordMode")) variable.Value = ssRecordMode; else variable.Optimized = true;
			} else if (head == "attributeprefix") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AttributePrefix")) variable.Value = ssAttributePrefix; else variable.Optimized = true;
			} else if (head == "contentprefix") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentPrefix")) variable.Value = ssContentPrefix; else variable.Optimized = true;
			} else if (head == "xmldeclaration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".XmlDeclaration")) variable.Value = ssXmlDeclaration; else variable.Optimized = true;
				variable.SetFieldName("xmldeclaration");
			} else if (head == "typedecimalculture") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TypeDecimalCulture")) variable.Value = ssTypeDecimalCulture; else variable.Optimized = true;
			} else if (head == "typedatetimeformat") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TypeDateTimeFormat")) variable.Value = ssTypeDateTimeFormat; else variable.Optimized = true;
			} else if (head == "typedateformat") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TypeDateFormat")) variable.Value = ssTypeDateFormat; else variable.Optimized = true;
			} else if (head == "typetimeformat") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TypeTimeFormat")) variable.Value = ssTypeTimeFormat; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdExcludeIfNull) {
				return ssExcludeIfNull;
			} else if (key == IdRecordListMode) {
				return ssRecordListMode;
			} else if (key == IdRecordMode) {
				return ssRecordMode;
			} else if (key == IdAttributePrefix) {
				return ssAttributePrefix;
			} else if (key == IdContentPrefix) {
				return ssContentPrefix;
			} else if (key == IdXmlDeclaration) {
				return ssXmlDeclaration;
			} else if (key == IdTypeDecimalCulture) {
				return ssTypeDecimalCulture;
			} else if (key == IdTypeDateTimeFormat) {
				return ssTypeDateTimeFormat;
			} else if (key == IdTypeDateFormat) {
				return ssTypeDateFormat;
			} else if (key == IdTypeTimeFormat) {
				return ssTypeTimeFormat;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssExcludeIfNull = (bool) other.AttributeGet(IdExcludeIfNull);
			ssRecordListMode = (string) other.AttributeGet(IdRecordListMode);
			ssRecordMode = (string) other.AttributeGet(IdRecordMode);
			ssAttributePrefix = (string) other.AttributeGet(IdAttributePrefix);
			ssContentPrefix = (string) other.AttributeGet(IdContentPrefix);
			ssXmlDeclaration.FillFromOther((IRecord) other.AttributeGet(IdXmlDeclaration));
			ssTypeDecimalCulture = (string) other.AttributeGet(IdTypeDecimalCulture);
			ssTypeDateTimeFormat = (string) other.AttributeGet(IdTypeDateTimeFormat);
			ssTypeDateFormat = (string) other.AttributeGet(IdTypeDateFormat);
			ssTypeTimeFormat = (string) other.AttributeGet(IdTypeTimeFormat);
		}
		public bool IsDefault() {
			STDefaultXmlConfigStructure defaultStruct = new STDefaultXmlConfigStructure(null);
			if (this.ssExcludeIfNull != defaultStruct.ssExcludeIfNull) return false;
			if (this.ssRecordListMode != defaultStruct.ssRecordListMode) return false;
			if (this.ssRecordMode != defaultStruct.ssRecordMode) return false;
			if (this.ssAttributePrefix != defaultStruct.ssAttributePrefix) return false;
			if (this.ssContentPrefix != defaultStruct.ssContentPrefix) return false;
			if (this.ssXmlDeclaration != defaultStruct.ssXmlDeclaration) return false;
			if (this.ssTypeDecimalCulture != defaultStruct.ssTypeDecimalCulture) return false;
			if (this.ssTypeDateTimeFormat != defaultStruct.ssTypeDateTimeFormat) return false;
			if (this.ssTypeDateFormat != defaultStruct.ssTypeDateFormat) return false;
			if (this.ssTypeTimeFormat != defaultStruct.ssTypeTimeFormat) return false;
			return true;
		}
	} // STDefaultXmlConfigStructure

	/// <summary>
	/// Structure <code>STXmlDeclarationStructure</code> that represents the Service Studio structure
	///  <code>XmlDeclaration</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STXmlDeclarationStructure: ISerializable, ITypedRecord<STXmlDeclarationStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdAddDeclaration = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*_G7_ytjfO0mod138Bm7+3w");
		internal static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*V26jDojpPEG_cGVu0w7JVg");
		internal static readonly GlobalObjectKey IdEncoding = GlobalObjectKey.Parse("CKIsH6O2Yk+pMNZYMYGVOw*NN1M76chD0+TYS+4C2frIw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AddDeclaration")]
		public bool ssAddDeclaration;

		[System.Xml.Serialization.XmlElement("Version")]
		public string ssVersion;

		[System.Xml.Serialization.XmlElement("Encoding")]
		public string ssEncoding;


		public BitArray OptimizedAttributes;

		public STXmlDeclarationStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssAddDeclaration = false;
			ssVersion = "1.0";
			ssEncoding = "UTF-8";
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
			ssAddDeclaration = r.ReadBoolean(index++, "XmlDeclaration.AddDeclaration", false);
			ssVersion = r.ReadText(index++, "XmlDeclaration.Version", "");
			ssEncoding = r.ReadText(index++, "XmlDeclaration.Encoding", "");
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
		public void ReadIM(STXmlDeclarationStructure r) {
			this = r;
		}


		public static bool operator == (STXmlDeclarationStructure a, STXmlDeclarationStructure b) {
			if (a.ssAddDeclaration != b.ssAddDeclaration) return false;
			if (a.ssVersion != b.ssVersion) return false;
			if (a.ssEncoding != b.ssEncoding) return false;
			return true;
		}

		public static bool operator != (STXmlDeclarationStructure a, STXmlDeclarationStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STXmlDeclarationStructure)) return false;
			return (this == (STXmlDeclarationStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAddDeclaration.GetHashCode()
				^ ssVersion.GetHashCode()
				^ ssEncoding.GetHashCode()
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

		public STXmlDeclarationStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssAddDeclaration = false;
			ssVersion = "1.0";
			ssEncoding = "UTF-8";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssAddDeclaration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAddDeclaration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAddDeclaration = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssVersion = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssEncoding", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEncoding' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEncoding = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STXmlDeclarationStructure Duplicate() {
			STXmlDeclarationStructure t;
			t.ssAddDeclaration = this.ssAddDeclaration;
			t.ssVersion = this.ssVersion;
			t.ssEncoding = this.ssEncoding;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AddDeclaration")) VarValue.AppendAttribute(recordElem, "AddDeclaration", ssAddDeclaration, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "AddDeclaration");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Version")) VarValue.AppendAttribute(recordElem, "Version", ssVersion, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Version");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Encoding")) VarValue.AppendAttribute(recordElem, "Encoding", ssEncoding, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Encoding");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "adddeclaration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AddDeclaration")) variable.Value = ssAddDeclaration; else variable.Optimized = true;
			} else if (head == "version") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
			} else if (head == "encoding") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Encoding")) variable.Value = ssEncoding; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAddDeclaration) {
				return ssAddDeclaration;
			} else if (key == IdVersion) {
				return ssVersion;
			} else if (key == IdEncoding) {
				return ssEncoding;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssAddDeclaration = (bool) other.AttributeGet(IdAddDeclaration);
			ssVersion = (string) other.AttributeGet(IdVersion);
			ssEncoding = (string) other.AttributeGet(IdEncoding);
		}
		public bool IsDefault() {
			STXmlDeclarationStructure defaultStruct = new STXmlDeclarationStructure(null);
			if (this.ssAddDeclaration != defaultStruct.ssAddDeclaration) return false;
			if (this.ssVersion != defaultStruct.ssVersion) return false;
			if (this.ssEncoding != defaultStruct.ssEncoding) return false;
			return true;
		}
	} // STXmlDeclarationStructure

} // OutSystems.NssXmlRecords

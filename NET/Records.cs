using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssXmlRecords {

	/// <summary>
	/// Structure <code>RCTestEntRecordRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTestEntRecordRecord: ISerializable, ITypedRecord<RCTestEntRecordRecord> {
		internal static readonly GlobalObjectKey IdTestEntRecord = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3XIX6zuWlJhZ9kjIQQuCdQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TestEntRecord")]
		public ENTestEntRecordEntityRecord ssENTestEntRecord;


		public static implicit operator ENTestEntRecordEntityRecord(RCTestEntRecordRecord r) {
			return r.ssENTestEntRecord;
		}

		public static implicit operator RCTestEntRecordRecord(ENTestEntRecordEntityRecord r) {
			RCTestEntRecordRecord res = new RCTestEntRecordRecord(null);
			res.ssENTestEntRecord = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENTestEntRecord.ChangedAttributes = value;
			}
			get {
				return ssENTestEntRecord.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCTestEntRecordRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENTestEntRecord = new ENTestEntRecordEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(2, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENTestEntRecord.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENTestEntRecord.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENTestEntRecord.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENTestEntRecord.Read(r, ref index);
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
		public void ReadIM(RCTestEntRecordRecord r) {
			this = r;
		}


		public static bool operator == (RCTestEntRecordRecord a, RCTestEntRecordRecord b) {
			if (a.ssENTestEntRecord != b.ssENTestEntRecord) return false;
			return true;
		}

		public static bool operator != (RCTestEntRecordRecord a, RCTestEntRecordRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTestEntRecordRecord)) return false;
			return (this == (RCTestEntRecordRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENTestEntRecord.GetHashCode()
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

		public RCTestEntRecordRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENTestEntRecord = new ENTestEntRecordEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENTestEntRecord", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENTestEntRecord' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENTestEntRecord = (ENTestEntRecordEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENTestEntRecord.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENTestEntRecord.InternalRecursiveSave();
		}


		public RCTestEntRecordRecord Duplicate() {
			RCTestEntRecordRecord t;
			t.ssENTestEntRecord = (ENTestEntRecordEntityRecord) this.ssENTestEntRecord.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENTestEntRecord.ToXml(this, recordElem, "TestEntRecord", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "testentrecord") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TestEntRecord")) variable.Value = ssENTestEntRecord; else variable.Optimized = true;
				variable.SetFieldName("testentrecord");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENTestEntRecord.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENTestEntRecord.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTestEntRecord) {
				return ssENTestEntRecord;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENTestEntRecord.FillFromOther((IRecord) other.AttributeGet(IdTestEntRecord));
		}
		public bool IsDefault() {
			RCTestEntRecordRecord defaultStruct = new RCTestEntRecordRecord(null);
			if (this.ssENTestEntRecord != defaultStruct.ssENTestEntRecord) return false;
			return true;
		}
	} // RCTestEntRecordRecord

	/// <summary>
	/// Structure <code>RCTestRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTestRecord: ISerializable, ITypedRecord<RCTestRecord> {
		internal static readonly GlobalObjectKey IdTest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iZOYqPizHJj_K3jkvg3ZJg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Test")]
		public STTestStructure ssSTTest;


		public static implicit operator STTestStructure(RCTestRecord r) {
			return r.ssSTTest;
		}

		public static implicit operator RCTestRecord(STTestStructure r) {
			RCTestRecord res = new RCTestRecord(null);
			res.ssSTTest = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTestRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTTest = new STTestStructure(null);
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
					ssSTTest.OptimizedAttributes = value[0];
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
			ssSTTest.Read(r, ref index);
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
		public void ReadIM(RCTestRecord r) {
			this = r;
		}


		public static bool operator == (RCTestRecord a, RCTestRecord b) {
			if (a.ssSTTest != b.ssSTTest) return false;
			return true;
		}

		public static bool operator != (RCTestRecord a, RCTestRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTestRecord)) return false;
			return (this == (RCTestRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTTest.GetHashCode()
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

		public RCTestRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTTest = new STTestStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTTest", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTTest' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTTest = (STTestStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTTest.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTTest.InternalRecursiveSave();
		}


		public RCTestRecord Duplicate() {
			RCTestRecord t;
			t.ssSTTest = (STTestStructure) this.ssSTTest.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTTest.ToXml(this, recordElem, "Test", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "test") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Test")) variable.Value = ssSTTest; else variable.Optimized = true;
				variable.SetFieldName("test");
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
			if (key == IdTest) {
				return ssSTTest;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTTest.FillFromOther((IRecord) other.AttributeGet(IdTest));
		}
		public bool IsDefault() {
			RCTestRecord defaultStruct = new RCTestRecord(null);
			if (this.ssSTTest != defaultStruct.ssSTTest) return false;
			return true;
		}
	} // RCTestRecord

	/// <summary>
	/// Structure <code>RCTestHierarchicalRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTestHierarchicalRecord: ISerializable, ITypedRecord<RCTestHierarchicalRecord> {
		internal static readonly GlobalObjectKey IdTestHierarchical = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FVPK6j2HLqbDJISk8bU2rw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TestHierarchical")]
		public STTestHierarchicalStructure ssSTTestHierarchical;


		public static implicit operator STTestHierarchicalStructure(RCTestHierarchicalRecord r) {
			return r.ssSTTestHierarchical;
		}

		public static implicit operator RCTestHierarchicalRecord(STTestHierarchicalStructure r) {
			RCTestHierarchicalRecord res = new RCTestHierarchicalRecord(null);
			res.ssSTTestHierarchical = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTestHierarchicalRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTTestHierarchical = new STTestHierarchicalStructure(null);
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
					ssSTTestHierarchical.OptimizedAttributes = value[0];
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
			ssSTTestHierarchical.Read(r, ref index);
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
		public void ReadIM(RCTestHierarchicalRecord r) {
			this = r;
		}


		public static bool operator == (RCTestHierarchicalRecord a, RCTestHierarchicalRecord b) {
			if (a.ssSTTestHierarchical != b.ssSTTestHierarchical) return false;
			return true;
		}

		public static bool operator != (RCTestHierarchicalRecord a, RCTestHierarchicalRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTestHierarchicalRecord)) return false;
			return (this == (RCTestHierarchicalRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTTestHierarchical.GetHashCode()
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

		public RCTestHierarchicalRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTTestHierarchical = new STTestHierarchicalStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTTestHierarchical", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTTestHierarchical' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTTestHierarchical = (STTestHierarchicalStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTTestHierarchical.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTTestHierarchical.InternalRecursiveSave();
		}


		public RCTestHierarchicalRecord Duplicate() {
			RCTestHierarchicalRecord t;
			t.ssSTTestHierarchical = (STTestHierarchicalStructure) this.ssSTTestHierarchical.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTTestHierarchical.ToXml(this, recordElem, "TestHierarchical", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "testhierarchical") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TestHierarchical")) variable.Value = ssSTTestHierarchical; else variable.Optimized = true;
				variable.SetFieldName("testhierarchical");
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
			if (key == IdTestHierarchical) {
				return ssSTTestHierarchical;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTTestHierarchical.FillFromOther((IRecord) other.AttributeGet(IdTestHierarchical));
		}
		public bool IsDefault() {
			RCTestHierarchicalRecord defaultStruct = new RCTestHierarchicalRecord(null);
			if (this.ssSTTestHierarchical != defaultStruct.ssSTTestHierarchical) return false;
			return true;
		}
	} // RCTestHierarchicalRecord

	/// <summary>
	/// Structure <code>RCRecordXmlConfigRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCRecordXmlConfigRecord: ISerializable, ITypedRecord<RCRecordXmlConfigRecord> {
		internal static readonly GlobalObjectKey IdRecordXmlConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wuSJNm+_QEIS5zObYf32ug");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("RecordXmlConfig")]
		public STRecordXmlConfigStructure ssSTRecordXmlConfig;


		public static implicit operator STRecordXmlConfigStructure(RCRecordXmlConfigRecord r) {
			return r.ssSTRecordXmlConfig;
		}

		public static implicit operator RCRecordXmlConfigRecord(STRecordXmlConfigStructure r) {
			RCRecordXmlConfigRecord res = new RCRecordXmlConfigRecord(null);
			res.ssSTRecordXmlConfig = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCRecordXmlConfigRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTRecordXmlConfig = new STRecordXmlConfigStructure(null);
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
					ssSTRecordXmlConfig.OptimizedAttributes = value[0];
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
			ssSTRecordXmlConfig.Read(r, ref index);
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
		public void ReadIM(RCRecordXmlConfigRecord r) {
			this = r;
		}


		public static bool operator == (RCRecordXmlConfigRecord a, RCRecordXmlConfigRecord b) {
			if (a.ssSTRecordXmlConfig != b.ssSTRecordXmlConfig) return false;
			return true;
		}

		public static bool operator != (RCRecordXmlConfigRecord a, RCRecordXmlConfigRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCRecordXmlConfigRecord)) return false;
			return (this == (RCRecordXmlConfigRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTRecordXmlConfig.GetHashCode()
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

		public RCRecordXmlConfigRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTRecordXmlConfig = new STRecordXmlConfigStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTRecordXmlConfig", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTRecordXmlConfig' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTRecordXmlConfig = (STRecordXmlConfigStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTRecordXmlConfig.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTRecordXmlConfig.InternalRecursiveSave();
		}


		public RCRecordXmlConfigRecord Duplicate() {
			RCRecordXmlConfigRecord t;
			t.ssSTRecordXmlConfig = (STRecordXmlConfigStructure) this.ssSTRecordXmlConfig.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTRecordXmlConfig.ToXml(this, recordElem, "RecordXmlConfig", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "recordxmlconfig") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordXmlConfig")) variable.Value = ssSTRecordXmlConfig; else variable.Optimized = true;
				variable.SetFieldName("recordxmlconfig");
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
			if (key == IdRecordXmlConfig) {
				return ssSTRecordXmlConfig;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTRecordXmlConfig.FillFromOther((IRecord) other.AttributeGet(IdRecordXmlConfig));
		}
		public bool IsDefault() {
			RCRecordXmlConfigRecord defaultStruct = new RCRecordXmlConfigRecord(null);
			if (this.ssSTRecordXmlConfig != defaultStruct.ssSTRecordXmlConfig) return false;
			return true;
		}
	} // RCRecordXmlConfigRecord

	/// <summary>
	/// Structure <code>RCAttributeXmlConfigRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAttributeXmlConfigRecord: ISerializable, ITypedRecord<RCAttributeXmlConfigRecord> {
		internal static readonly GlobalObjectKey IdAttributeXmlConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iYkVNah3cQGuWjuqjjTH9g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AttributeXmlConfig")]
		public STAttributeXmlConfigStructure ssSTAttributeXmlConfig;


		public static implicit operator STAttributeXmlConfigStructure(RCAttributeXmlConfigRecord r) {
			return r.ssSTAttributeXmlConfig;
		}

		public static implicit operator RCAttributeXmlConfigRecord(STAttributeXmlConfigStructure r) {
			RCAttributeXmlConfigRecord res = new RCAttributeXmlConfigRecord(null);
			res.ssSTAttributeXmlConfig = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAttributeXmlConfigRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAttributeXmlConfig = new STAttributeXmlConfigStructure(null);
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
					ssSTAttributeXmlConfig.OptimizedAttributes = value[0];
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
			ssSTAttributeXmlConfig.Read(r, ref index);
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
		public void ReadIM(RCAttributeXmlConfigRecord r) {
			this = r;
		}


		public static bool operator == (RCAttributeXmlConfigRecord a, RCAttributeXmlConfigRecord b) {
			if (a.ssSTAttributeXmlConfig != b.ssSTAttributeXmlConfig) return false;
			return true;
		}

		public static bool operator != (RCAttributeXmlConfigRecord a, RCAttributeXmlConfigRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAttributeXmlConfigRecord)) return false;
			return (this == (RCAttributeXmlConfigRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAttributeXmlConfig.GetHashCode()
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

		public RCAttributeXmlConfigRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAttributeXmlConfig = new STAttributeXmlConfigStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAttributeXmlConfig", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAttributeXmlConfig' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAttributeXmlConfig = (STAttributeXmlConfigStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAttributeXmlConfig.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAttributeXmlConfig.InternalRecursiveSave();
		}


		public RCAttributeXmlConfigRecord Duplicate() {
			RCAttributeXmlConfigRecord t;
			t.ssSTAttributeXmlConfig = (STAttributeXmlConfigStructure) this.ssSTAttributeXmlConfig.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAttributeXmlConfig.ToXml(this, recordElem, "AttributeXmlConfig", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attributexmlconfig") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AttributeXmlConfig")) variable.Value = ssSTAttributeXmlConfig; else variable.Optimized = true;
				variable.SetFieldName("attributexmlconfig");
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
			if (key == IdAttributeXmlConfig) {
				return ssSTAttributeXmlConfig;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAttributeXmlConfig.FillFromOther((IRecord) other.AttributeGet(IdAttributeXmlConfig));
		}
		public bool IsDefault() {
			RCAttributeXmlConfigRecord defaultStruct = new RCAttributeXmlConfigRecord(null);
			if (this.ssSTAttributeXmlConfig != defaultStruct.ssSTAttributeXmlConfig) return false;
			return true;
		}
	} // RCAttributeXmlConfigRecord

	/// <summary>
	/// Structure <code>RCDefaultXmlConfigRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDefaultXmlConfigRecord: ISerializable, ITypedRecord<RCDefaultXmlConfigRecord> {
		internal static readonly GlobalObjectKey IdDefaultXmlConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Lq51WXTxQRI5VdfskdmAPA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DefaultXmlConfig")]
		public STDefaultXmlConfigStructure ssSTDefaultXmlConfig;


		public static implicit operator STDefaultXmlConfigStructure(RCDefaultXmlConfigRecord r) {
			return r.ssSTDefaultXmlConfig;
		}

		public static implicit operator RCDefaultXmlConfigRecord(STDefaultXmlConfigStructure r) {
			RCDefaultXmlConfigRecord res = new RCDefaultXmlConfigRecord(null);
			res.ssSTDefaultXmlConfig = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDefaultXmlConfigRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDefaultXmlConfig = new STDefaultXmlConfigStructure(null);
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
					ssSTDefaultXmlConfig.OptimizedAttributes = value[0];
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
			ssSTDefaultXmlConfig.Read(r, ref index);
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
		public void ReadIM(RCDefaultXmlConfigRecord r) {
			this = r;
		}


		public static bool operator == (RCDefaultXmlConfigRecord a, RCDefaultXmlConfigRecord b) {
			if (a.ssSTDefaultXmlConfig != b.ssSTDefaultXmlConfig) return false;
			return true;
		}

		public static bool operator != (RCDefaultXmlConfigRecord a, RCDefaultXmlConfigRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDefaultXmlConfigRecord)) return false;
			return (this == (RCDefaultXmlConfigRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDefaultXmlConfig.GetHashCode()
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

		public RCDefaultXmlConfigRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDefaultXmlConfig = new STDefaultXmlConfigStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDefaultXmlConfig", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDefaultXmlConfig' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDefaultXmlConfig = (STDefaultXmlConfigStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDefaultXmlConfig.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDefaultXmlConfig.InternalRecursiveSave();
		}


		public RCDefaultXmlConfigRecord Duplicate() {
			RCDefaultXmlConfigRecord t;
			t.ssSTDefaultXmlConfig = (STDefaultXmlConfigStructure) this.ssSTDefaultXmlConfig.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDefaultXmlConfig.ToXml(this, recordElem, "DefaultXmlConfig", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "defaultxmlconfig") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DefaultXmlConfig")) variable.Value = ssSTDefaultXmlConfig; else variable.Optimized = true;
				variable.SetFieldName("defaultxmlconfig");
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
			if (key == IdDefaultXmlConfig) {
				return ssSTDefaultXmlConfig;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDefaultXmlConfig.FillFromOther((IRecord) other.AttributeGet(IdDefaultXmlConfig));
		}
		public bool IsDefault() {
			RCDefaultXmlConfigRecord defaultStruct = new RCDefaultXmlConfigRecord(null);
			if (this.ssSTDefaultXmlConfig != defaultStruct.ssSTDefaultXmlConfig) return false;
			return true;
		}
	} // RCDefaultXmlConfigRecord

	/// <summary>
	/// Structure <code>RCXmlDeclarationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCXmlDeclarationRecord: ISerializable, ITypedRecord<RCXmlDeclarationRecord> {
		internal static readonly GlobalObjectKey IdXmlDeclaration = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UohsDROuDoY8T+HfFJu1Pw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("XmlDeclaration")]
		public STXmlDeclarationStructure ssSTXmlDeclaration;


		public static implicit operator STXmlDeclarationStructure(RCXmlDeclarationRecord r) {
			return r.ssSTXmlDeclaration;
		}

		public static implicit operator RCXmlDeclarationRecord(STXmlDeclarationStructure r) {
			RCXmlDeclarationRecord res = new RCXmlDeclarationRecord(null);
			res.ssSTXmlDeclaration = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCXmlDeclarationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTXmlDeclaration = new STXmlDeclarationStructure(null);
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
					ssSTXmlDeclaration.OptimizedAttributes = value[0];
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
			ssSTXmlDeclaration.Read(r, ref index);
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
		public void ReadIM(RCXmlDeclarationRecord r) {
			this = r;
		}


		public static bool operator == (RCXmlDeclarationRecord a, RCXmlDeclarationRecord b) {
			if (a.ssSTXmlDeclaration != b.ssSTXmlDeclaration) return false;
			return true;
		}

		public static bool operator != (RCXmlDeclarationRecord a, RCXmlDeclarationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCXmlDeclarationRecord)) return false;
			return (this == (RCXmlDeclarationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTXmlDeclaration.GetHashCode()
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

		public RCXmlDeclarationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTXmlDeclaration = new STXmlDeclarationStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTXmlDeclaration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTXmlDeclaration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTXmlDeclaration = (STXmlDeclarationStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTXmlDeclaration.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTXmlDeclaration.InternalRecursiveSave();
		}


		public RCXmlDeclarationRecord Duplicate() {
			RCXmlDeclarationRecord t;
			t.ssSTXmlDeclaration = (STXmlDeclarationStructure) this.ssSTXmlDeclaration.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTXmlDeclaration.ToXml(this, recordElem, "XmlDeclaration", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "xmldeclaration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".XmlDeclaration")) variable.Value = ssSTXmlDeclaration; else variable.Optimized = true;
				variable.SetFieldName("xmldeclaration");
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
			if (key == IdXmlDeclaration) {
				return ssSTXmlDeclaration;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTXmlDeclaration.FillFromOther((IRecord) other.AttributeGet(IdXmlDeclaration));
		}
		public bool IsDefault() {
			RCXmlDeclarationRecord defaultStruct = new RCXmlDeclarationRecord(null);
			if (this.ssSTXmlDeclaration != defaultStruct.ssSTXmlDeclaration) return false;
			return true;
		}
	} // RCXmlDeclarationRecord
}

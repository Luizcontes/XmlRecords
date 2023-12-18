using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssXmlRecords {

	/// <summary>
	/// RecordList type <code>RLTestEntRecordRecordList</code> that represents a record list of
	///  <code>TestEntRecord</code>
	/// </summary>
	[Serializable()]
	public partial class RLTestEntRecordRecordList: GenericRecordList<RCTestEntRecordRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTestEntRecordRecord GetElementDefaultValue() {
			return new RCTestEntRecordRecord("");
		}

		public T[] ToArray<T>(Func<RCTestEntRecordRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTestEntRecordRecordList recordlist, Func<RCTestEntRecordRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTestEntRecordRecordList(RCTestEntRecordRecord[] array) {
			RLTestEntRecordRecordList result = new RLTestEntRecordRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTestEntRecordRecordList ToList<T>(T[] array, Func <T, RCTestEntRecordRecord> converter) {
			RLTestEntRecordRecordList result = new RLTestEntRecordRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTestEntRecordRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTestEntRecordRecord> converter) {
			RLTestEntRecordRecordList result = new RLTestEntRecordRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTestEntRecordRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTestEntRecordRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTestEntRecordRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTestEntRecordRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(2, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTestEntRecordRecord> NewList() {
			return new RLTestEntRecordRecordList();
		}


	} // RLTestEntRecordRecordList

	/// <summary>
	/// RecordList type <code>RLTestRecordList</code> that represents a record list of <code>Test</code>
	/// </summary>
	[Serializable()]
	public partial class RLTestRecordList: GenericRecordList<RCTestRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTestRecord GetElementDefaultValue() {
			return new RCTestRecord("");
		}

		public T[] ToArray<T>(Func<RCTestRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTestRecordList recordlist, Func<RCTestRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTestRecordList(RCTestRecord[] array) {
			RLTestRecordList result = new RLTestRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTestRecordList ToList<T>(T[] array, Func <T, RCTestRecord> converter) {
			RLTestRecordList result = new RLTestRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTestRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTestRecord> converter) {
			RLTestRecordList result = new RLTestRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTestRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTestRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTestRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTestRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTestRecord> NewList() {
			return new RLTestRecordList();
		}


	} // RLTestRecordList

	/// <summary>
	/// RecordList type <code>RLTestHierarchicalRecordList</code> that represents a record list of
	///  <code>TestHierarchical</code>
	/// </summary>
	[Serializable()]
	public partial class RLTestHierarchicalRecordList: GenericRecordList<RCTestHierarchicalRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTestHierarchicalRecord GetElementDefaultValue() {
			return new RCTestHierarchicalRecord("");
		}

		public T[] ToArray<T>(Func<RCTestHierarchicalRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTestHierarchicalRecordList recordlist, Func<RCTestHierarchicalRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTestHierarchicalRecordList(RCTestHierarchicalRecord[] array) {
			RLTestHierarchicalRecordList result = new RLTestHierarchicalRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTestHierarchicalRecordList ToList<T>(T[] array, Func <T, RCTestHierarchicalRecord> converter) {
			RLTestHierarchicalRecordList result = new RLTestHierarchicalRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTestHierarchicalRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTestHierarchicalRecord> converter) {
			RLTestHierarchicalRecordList result = new RLTestHierarchicalRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTestHierarchicalRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTestHierarchicalRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTestHierarchicalRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTestHierarchicalRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTestHierarchicalRecord> NewList() {
			return new RLTestHierarchicalRecordList();
		}


	} // RLTestHierarchicalRecordList

	/// <summary>
	/// RecordList type <code>RLRecordXmlConfigRecordList</code> that represents a record list of
	///  <code>RecordXmlConfig</code>
	/// </summary>
	[Serializable()]
	public partial class RLRecordXmlConfigRecordList: GenericRecordList<RCRecordXmlConfigRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCRecordXmlConfigRecord GetElementDefaultValue() {
			return new RCRecordXmlConfigRecord("");
		}

		public T[] ToArray<T>(Func<RCRecordXmlConfigRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRecordXmlConfigRecordList recordlist, Func<RCRecordXmlConfigRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLRecordXmlConfigRecordList(RCRecordXmlConfigRecord[] array) {
			RLRecordXmlConfigRecordList result = new RLRecordXmlConfigRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLRecordXmlConfigRecordList ToList<T>(T[] array, Func <T, RCRecordXmlConfigRecord> converter) {
			RLRecordXmlConfigRecordList result = new RLRecordXmlConfigRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLRecordXmlConfigRecordList FromRestList<T>(RestList<T> restList, Func <T, RCRecordXmlConfigRecord> converter) {
			RLRecordXmlConfigRecordList result = new RLRecordXmlConfigRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLRecordXmlConfigRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRecordXmlConfigRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRecordXmlConfigRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRecordXmlConfigRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCRecordXmlConfigRecord> NewList() {
			return new RLRecordXmlConfigRecordList();
		}


	} // RLRecordXmlConfigRecordList

	/// <summary>
	/// RecordList type <code>RLAttributeXmlConfigRecordList</code> that represents a record list of
	///  <code>AttributeXmlConfig</code>
	/// </summary>
	[Serializable()]
	public partial class RLAttributeXmlConfigRecordList: GenericRecordList<RCAttributeXmlConfigRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAttributeXmlConfigRecord GetElementDefaultValue() {
			return new RCAttributeXmlConfigRecord("");
		}

		public T[] ToArray<T>(Func<RCAttributeXmlConfigRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAttributeXmlConfigRecordList recordlist, Func<RCAttributeXmlConfigRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAttributeXmlConfigRecordList(RCAttributeXmlConfigRecord[] array) {
			RLAttributeXmlConfigRecordList result = new RLAttributeXmlConfigRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAttributeXmlConfigRecordList ToList<T>(T[] array, Func <T, RCAttributeXmlConfigRecord> converter) {
			RLAttributeXmlConfigRecordList result = new RLAttributeXmlConfigRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAttributeXmlConfigRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAttributeXmlConfigRecord> converter) {
			RLAttributeXmlConfigRecordList result = new RLAttributeXmlConfigRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAttributeXmlConfigRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttributeXmlConfigRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttributeXmlConfigRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAttributeXmlConfigRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAttributeXmlConfigRecord> NewList() {
			return new RLAttributeXmlConfigRecordList();
		}


	} // RLAttributeXmlConfigRecordList

	/// <summary>
	/// RecordList type <code>RLDefaultXmlConfigRecordList</code> that represents a record list of
	///  <code>DefaultXmlConfig</code>
	/// </summary>
	[Serializable()]
	public partial class RLDefaultXmlConfigRecordList: GenericRecordList<RCDefaultXmlConfigRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDefaultXmlConfigRecord GetElementDefaultValue() {
			return new RCDefaultXmlConfigRecord("");
		}

		public T[] ToArray<T>(Func<RCDefaultXmlConfigRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDefaultXmlConfigRecordList recordlist, Func<RCDefaultXmlConfigRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDefaultXmlConfigRecordList(RCDefaultXmlConfigRecord[] array) {
			RLDefaultXmlConfigRecordList result = new RLDefaultXmlConfigRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDefaultXmlConfigRecordList ToList<T>(T[] array, Func <T, RCDefaultXmlConfigRecord> converter) {
			RLDefaultXmlConfigRecordList result = new RLDefaultXmlConfigRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDefaultXmlConfigRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDefaultXmlConfigRecord> converter) {
			RLDefaultXmlConfigRecordList result = new RLDefaultXmlConfigRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDefaultXmlConfigRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDefaultXmlConfigRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDefaultXmlConfigRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDefaultXmlConfigRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDefaultXmlConfigRecord> NewList() {
			return new RLDefaultXmlConfigRecordList();
		}


	} // RLDefaultXmlConfigRecordList

	/// <summary>
	/// RecordList type <code>RLXmlDeclarationRecordList</code> that represents a record list of
	///  <code>XmlDeclaration</code>
	/// </summary>
	[Serializable()]
	public partial class RLXmlDeclarationRecordList: GenericRecordList<RCXmlDeclarationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCXmlDeclarationRecord GetElementDefaultValue() {
			return new RCXmlDeclarationRecord("");
		}

		public T[] ToArray<T>(Func<RCXmlDeclarationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLXmlDeclarationRecordList recordlist, Func<RCXmlDeclarationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLXmlDeclarationRecordList(RCXmlDeclarationRecord[] array) {
			RLXmlDeclarationRecordList result = new RLXmlDeclarationRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLXmlDeclarationRecordList ToList<T>(T[] array, Func <T, RCXmlDeclarationRecord> converter) {
			RLXmlDeclarationRecordList result = new RLXmlDeclarationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLXmlDeclarationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCXmlDeclarationRecord> converter) {
			RLXmlDeclarationRecordList result = new RLXmlDeclarationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLXmlDeclarationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLXmlDeclarationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLXmlDeclarationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLXmlDeclarationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCXmlDeclarationRecord> NewList() {
			return new RLXmlDeclarationRecordList();
		}


	} // RLXmlDeclarationRecordList
}

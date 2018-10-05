using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace UFTRepo
{
	[XmlRoot(ElementName="Value", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Value {
		[XmlAttribute(AttributeName="RegularExpression")]
		public string RegularExpression { get; set; }
		[XmlText]
		public string Text { get; set; }
		[XmlAttribute(AttributeName="Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName="Property", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Property {
		[XmlElement(ElementName="Value", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Value Value { get; set; }
		[XmlAttribute(AttributeName="Name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="Hidden")]
		public string Hidden { get; set; }
		[XmlAttribute(AttributeName="ReadOnly")]
		public string ReadOnly { get; set; }
		[XmlAttribute(AttributeName="Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName="Properties", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Properties {
		[XmlElement(ElementName="Property", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<Property> Property { get; set; }
	}

	[XmlRoot(ElementName="BasicIdentification", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class BasicIdentification {
		[XmlElement(ElementName="PropertyRef", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<string> PropertyRef { get; set; }
		[XmlElement(ElementName="OrdinalIdentifier", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public OrdinalIdentifier OrdinalIdentifier { get; set; }
	}

	[XmlRoot(ElementName="Behavior", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Behavior {
		[XmlAttribute(AttributeName="Name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="Type")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="CustomReplay", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class CustomReplay {
		[XmlElement(ElementName="Behavior", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Behavior Behavior { get; set; }
	}

	[XmlRoot(ElementName="Object", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Object {
		[XmlElement(ElementName="Properties", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Properties Properties { get; set; }
		[XmlElement(ElementName="BasicIdentification", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public BasicIdentification BasicIdentification { get; set; }
		[XmlElement(ElementName="CustomReplay", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public CustomReplay CustomReplay { get; set; }
		[XmlElement(ElementName="LastUpdateTime", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string LastUpdateTime { get; set; }
		[XmlAttribute(AttributeName="Class")]
		public string Class { get; set; }
		[XmlAttribute(AttributeName="Name")]
		public string Name { get; set; }
		[XmlElement(ElementName="ChildObjects", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public ChildObjects ChildObjects { get; set; }
		[XmlElement(ElementName="Comments", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Comments Comments { get; set; }
		[XmlElement(ElementName="VisualRelations", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string VisualRelations { get; set; }
		[XmlElement(ElementName="SmartIdentification", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public SmartIdentification SmartIdentification { get; set; }
	}

	[XmlRoot(ElementName="ChildObjects", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class ChildObjects {
		[XmlElement(ElementName="Object", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<Object> Object { get; set; }
	}

	[XmlRoot(ElementName="Comment", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Comment {
		[XmlAttribute(AttributeName="Name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName="Comments", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Comments {
		[XmlElement(ElementName="Comment", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Comment Comment { get; set; }
	}

	[XmlRoot(ElementName="OrdinalIdentifier", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class OrdinalIdentifier {
		[XmlElement(ElementName="Value", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName="Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName="BaseFilter", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class BaseFilter {
		[XmlElement(ElementName="PropertyRef", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<string> PropertyRef { get; set; }
	}

	[XmlRoot(ElementName="OptionalFilter", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class OptionalFilter {
		[XmlElement(ElementName="PropertyRef", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<string> PropertyRef { get; set; }
	}

	[XmlRoot(ElementName="SmartIdentification", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class SmartIdentification {
		[XmlElement(ElementName="BaseFilter", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public BaseFilter BaseFilter { get; set; }
		[XmlElement(ElementName="OptionalFilter", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public OptionalFilter OptionalFilter { get; set; }
		[XmlAttribute(AttributeName="Algorithm")]
		public string Algorithm { get; set; }
		[XmlAttribute(AttributeName="Active")]
		public string Active { get; set; }
	}

	[XmlRoot(ElementName="Argument", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Argument {
		[XmlElement(ElementName="Name", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string Name { get; set; }
		[XmlElement(ElementName="Value", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Value Value { get; set; }
	}

	[XmlRoot(ElementName="Arguments", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Arguments {
		[XmlElement(ElementName="Argument", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Argument Argument { get; set; }
	}

	[XmlRoot(ElementName="VisualRelation", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class VisualRelation {
		[XmlElement(ElementName="Arguments", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Arguments Arguments { get; set; }
		[XmlAttribute(AttributeName="RelatedObjectPath")]
		public string RelatedObjectPath { get; set; }
		[XmlAttribute(AttributeName="RelativePosition")]
		public string RelativePosition { get; set; }
	}

	[XmlRoot(ElementName="VisualRelations", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class VisualRelations {
		[XmlElement(ElementName="VisualRelation", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<VisualRelation> VisualRelation { get; set; }
	}

	[XmlRoot(ElementName="Objects", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class Objects {
		[XmlElement(ElementName="Object", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public List<Object> Object { get; set; }
	}

	[XmlRoot(ElementName="ObjectRepository", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
	public class ObjectRepository {
		[XmlElement(ElementName="Objects", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public Objects Objects { get; set; }
		[XmlElement(ElementName="CheckpointsAndOutputs", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string CheckpointsAndOutputs { get; set; }
		[XmlElement(ElementName="Parameters", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string Parameters { get; set; }
		[XmlElement(ElementName="Metadata", Namespace="http://www.mercury.com/qtp/ObjectRepository")]
		public string Metadata { get; set; }
		[XmlAttribute(AttributeName="qtpRep", Namespace="http://www.w3.org/2000/xmlns/")]
		public string QtpRep { get; set; }
	}

}

using System;
using  System.Collections;

namespace UFTRepo
{
    public class Codebeautify {
 ObjectRepository ObjectRepositoryObject;


 // Getter Methods 

 public ObjectRepository getObjectRepository() {
  return ObjectRepositoryObject;
 }

 // Setter Methods 

 public void setObjectRepository(ObjectRepository ObjectRepositoryObject) {
  this.ObjectRepositoryObject = ObjectRepositoryObject;
 }
}
public class ObjectRepository {
 Objects ObjectsObject;
 CheckpointsAndOutputs CheckpointsAndOutputsObject;
 Parameters ParametersObject;
 Metadata MetadataObject;
 private String _xmlns:qtpRep;
 private String __prefix;


 // Getter Methods 

 public Objects getObjects() {
  return ObjectsObject;
 }

 public CheckpointsAndOutputs getCheckpointsAndOutputs() {
  return CheckpointsAndOutputsObject;
 }

 public Parameters getParameters() {
  return ParametersObject;
 }

 public Metadata getMetadata() {
  return MetadataObject;
 }

 public String get_xmlns: qtpRep() {
  return _xmlns: qtpRep;
 }

 public String get__prefix() {
  return __prefix;
 }

 // Setter Methods 

 public void setObjects(Objects ObjectsObject) {
  this.ObjectsObject = ObjectsObject;
 }

 public void setCheckpointsAndOutputs(CheckpointsAndOutputs CheckpointsAndOutputsObject) {
  this.CheckpointsAndOutputsObject = CheckpointsAndOutputsObject;
 }

 public void setParameters(Parameters ParametersObject) {
  this.ParametersObject = ParametersObject;
 }

 public void setMetadata(Metadata MetadataObject) {
  this.MetadataObject = MetadataObject;
 }

 public void set_xmlns: qtpRep(String _xmlns: qtpRep) {
  this._xmlns: qtpRep = _xmlns: qtpRep;
 }

 public void set__prefix(String __prefix) {
  this.__prefix = __prefix;
 }
}
public class Metadata {
 private String __prefix;


 // Getter Methods 

 public String get__prefix() {
  return __prefix;
 }

 // Setter Methods 

 public void set__prefix(String __prefix) {
  this.__prefix = __prefix;
 }
}
public class Parameters {
 private String __prefix;


 // Getter Methods 

 public String get__prefix() {
  return __prefix;
 }

 // Setter Methods 

 public void set__prefix(String __prefix) {
  this.__prefix = __prefix;
 }
}
public class CheckpointsAndOutputs {
 private String __prefix;


 // Getter Methods 

 public String get__prefix() {
  return __prefix;
 }

 // Setter Methods 

 public void set__prefix(String __prefix) {
  this.__prefix = __prefix;
 }
}
public class Objects {
 ArrayList < Object > Object = new ArrayList < Object > ();
 private String __prefix;


 // Getter Methods 

 public String get__prefix() {
  return __prefix;
 }

 // Setter Methods 

 public void set__prefix(String __prefix) {
  this.__prefix = __prefix;
 }
}
}

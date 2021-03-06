/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class FT_UnitData : FT_DataBase {
  private HandleRef swigCPtr;

  internal FT_UnitData(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.FT_UnitData_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FT_UnitData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FT_UnitData() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FT_UnitData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint iID {
    set {
      RakNetPINVOKE.FT_UnitData_iID_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.FT_UnitData_iID_get(swigCPtr);
      return ret;
    } 
  }

  public byte iLevel {
    set {
      RakNetPINVOKE.FT_UnitData_iLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = RakNetPINVOKE.FT_UnitData_iLevel_get(swigCPtr);
      return ret;
    } 
  }

  public FT_EUnit eUnit {
    set {
      RakNetPINVOKE.FT_UnitData_eUnit_set(swigCPtr, (int)value);
    } 
    get {
      FT_EUnit ret = (FT_EUnit)RakNetPINVOKE.FT_UnitData_eUnit_get(swigCPtr);
      return ret;
    } 
  }

  public byte nGridSize {
    set {
      RakNetPINVOKE.FT_UnitData_nGridSize_set(swigCPtr, value);
    } 
    get {
      byte ret = RakNetPINVOKE.FT_UnitData_nGridSize_get(swigCPtr);
      return ret;
    } 
  }

  public sbyte nGrid_x {
    set {
      RakNetPINVOKE.FT_UnitData_nGrid_x_set(swigCPtr, value);
    } 
    get {
      sbyte ret = RakNetPINVOKE.FT_UnitData_nGrid_x_get(swigCPtr);
      return ret;
    } 
  }

  public sbyte nGrid_y {
    set {
      RakNetPINVOKE.FT_UnitData_nGrid_y_set(swigCPtr, value);
    } 
    get {
      sbyte ret = RakNetPINVOKE.FT_UnitData_nGrid_y_get(swigCPtr);
      return ret;
    } 
  }

  public RakString sName {
    set {
      RakNetPINVOKE.FT_UnitData_sName_set(swigCPtr, RakString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FT_UnitData_sName_get(swigCPtr);
      RakString ret = (cPtr == IntPtr.Zero) ? null : new RakString(cPtr, false);
      return ret;
    } 
  }

  public RakString sInfo {
    set {
      RakNetPINVOKE.FT_UnitData_sInfo_set(swigCPtr, RakString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FT_UnitData_sInfo_get(swigCPtr);
      RakString ret = (cPtr == IntPtr.Zero) ? null : new RakString(cPtr, false);
      return ret;
    } 
  }

  public FT_UnitData() : this(RakNetPINVOKE.new_FT_UnitData__SWIG_0(), true) {
  }

  public FT_UnitData(FT_Session session) : this(RakNetPINVOKE.new_FT_UnitData__SWIG_1(FT_Session.getCPtr(session)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FT_MessageTypesNode NodeType() {
    FT_MessageTypesNode ret = (FT_MessageTypesNode)RakNetPINVOKE.FT_UnitData_NodeType(swigCPtr);
    return ret;
  }

  public override void Serialize(bool writeToBitstream, BitStream bs) {
    RakNetPINVOKE.FT_UnitData_Serialize(swigCPtr, writeToBitstream, BitStream.getCPtr(bs));
  }

}

}

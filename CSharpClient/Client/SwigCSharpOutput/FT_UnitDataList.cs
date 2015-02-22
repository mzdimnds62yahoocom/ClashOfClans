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

public class FT_UnitDataList : FT_DataBase {
  private HandleRef swigCPtr;

  internal FT_UnitDataList(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.FT_UnitDataList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FT_UnitDataList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FT_UnitDataList() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FT_UnitDataList(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint iDataLength {
    set {
      RakNetPINVOKE.FT_UnitDataList_iDataLength_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.FT_UnitDataList_iDataLength_get(swigCPtr);
      return ret;
    } 
  }

  public FT_UnitDataList() : this(RakNetPINVOKE.new_FT_UnitDataList(), true) {
  }

  public void PushUnitData2List(FT_UnitData data) {
    RakNetPINVOKE.FT_UnitDataList_PushUnitData2List(swigCPtr, FT_UnitData.getCPtr(data));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_DataStructures__ListT_RakNet__FT_UnitData_t GetUnitDataList() {
    SWIGTYPE_p_DataStructures__ListT_RakNet__FT_UnitData_t ret = new SWIGTYPE_p_DataStructures__ListT_RakNet__FT_UnitData_t(RakNetPINVOKE.FT_UnitDataList_GetUnitDataList(swigCPtr), true);
    return ret;
  }

  public override FT_MessageTypesNode NodeType() {
    FT_MessageTypesNode ret = (FT_MessageTypesNode)RakNetPINVOKE.FT_UnitDataList_NodeType(swigCPtr);
    return ret;
  }

  public override void Serialize(bool writeToBitstream, BitStream bs) {
    RakNetPINVOKE.FT_UnitDataList_Serialize(swigCPtr, writeToBitstream, BitStream.getCPtr(bs));
  }

}

}
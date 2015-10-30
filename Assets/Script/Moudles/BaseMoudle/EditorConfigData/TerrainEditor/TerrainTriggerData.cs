/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace TerrainEditor
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TerrainTriggerData : TBase
  {
    private ETriggerType _type;
    private ETriggerAreaType _areaType;
    private string _resName;
    private Common.Auto.ThriftVector3 _pos;
    private Common.Auto.ThriftVector3 _rot;
    private Common.Auto.ThriftVector3 _scale;
    private int _targetMethodId;
    private int _limitMethodId;
    private int _enterFuncMethodId;
    private int _exitFuncMethodId;

    /// <summary>
    /// 
    /// <seealso cref="ETriggerType"/>
    /// </summary>
    public ETriggerType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ETriggerAreaType"/>
    /// </summary>
    public ETriggerAreaType AreaType
    {
      get
      {
        return _areaType;
      }
      set
      {
        __isset.areaType = true;
        this._areaType = value;
      }
    }

    public string ResName
    {
      get
      {
        return _resName;
      }
      set
      {
        __isset.resName = true;
        this._resName = value;
      }
    }

    public Common.Auto.ThriftVector3 Pos
    {
      get
      {
        return _pos;
      }
      set
      {
        __isset.pos = true;
        this._pos = value;
      }
    }

    public Common.Auto.ThriftVector3 Rot
    {
      get
      {
        return _rot;
      }
      set
      {
        __isset.rot = true;
        this._rot = value;
      }
    }

    public Common.Auto.ThriftVector3 Scale
    {
      get
      {
        return _scale;
      }
      set
      {
        __isset.scale = true;
        this._scale = value;
      }
    }

    public int TargetMethodId
    {
      get
      {
        return _targetMethodId;
      }
      set
      {
        __isset.targetMethodId = true;
        this._targetMethodId = value;
      }
    }

    public int LimitMethodId
    {
      get
      {
        return _limitMethodId;
      }
      set
      {
        __isset.limitMethodId = true;
        this._limitMethodId = value;
      }
    }

    public int EnterFuncMethodId
    {
      get
      {
        return _enterFuncMethodId;
      }
      set
      {
        __isset.enterFuncMethodId = true;
        this._enterFuncMethodId = value;
      }
    }

    public int ExitFuncMethodId
    {
      get
      {
        return _exitFuncMethodId;
      }
      set
      {
        __isset.exitFuncMethodId = true;
        this._exitFuncMethodId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool type;
      public bool areaType;
      public bool resName;
      public bool pos;
      public bool rot;
      public bool scale;
      public bool targetMethodId;
      public bool limitMethodId;
      public bool enterFuncMethodId;
      public bool exitFuncMethodId;
    }

    public TerrainTriggerData() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Type = (ETriggerType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              AreaType = (ETriggerAreaType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              ResName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Struct) {
              Pos = new Common.Auto.ThriftVector3();
              Pos.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.Struct) {
              Rot = new Common.Auto.ThriftVector3();
              Rot.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.Struct) {
              Scale = new Common.Auto.ThriftVector3();
              Scale.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 60:
            if (field.Type == TType.I32) {
              TargetMethodId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 70:
            if (field.Type == TType.I32) {
              LimitMethodId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 80:
            if (field.Type == TType.I32) {
              EnterFuncMethodId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 90:
            if (field.Type == TType.I32) {
              ExitFuncMethodId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TerrainTriggerData");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Type);
        oprot.WriteFieldEnd();
      }
      if (__isset.areaType) {
        field.Name = "areaType";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)AreaType);
        oprot.WriteFieldEnd();
      }
      if (ResName != null && __isset.resName) {
        field.Name = "resName";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ResName);
        oprot.WriteFieldEnd();
      }
      if (Pos != null && __isset.pos) {
        field.Name = "pos";
        field.Type = TType.Struct;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        Pos.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Rot != null && __isset.rot) {
        field.Name = "rot";
        field.Type = TType.Struct;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        Rot.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Scale != null && __isset.scale) {
        field.Name = "scale";
        field.Type = TType.Struct;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        Scale.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetMethodId) {
        field.Name = "targetMethodId";
        field.Type = TType.I32;
        field.ID = 60;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetMethodId);
        oprot.WriteFieldEnd();
      }
      if (__isset.limitMethodId) {
        field.Name = "limitMethodId";
        field.Type = TType.I32;
        field.ID = 70;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(LimitMethodId);
        oprot.WriteFieldEnd();
      }
      if (__isset.enterFuncMethodId) {
        field.Name = "enterFuncMethodId";
        field.Type = TType.I32;
        field.ID = 80;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(EnterFuncMethodId);
        oprot.WriteFieldEnd();
      }
      if (__isset.exitFuncMethodId) {
        field.Name = "exitFuncMethodId";
        field.Type = TType.I32;
        field.ID = 90;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ExitFuncMethodId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TerrainTriggerData(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",AreaType: ");
      sb.Append(AreaType);
      sb.Append(",ResName: ");
      sb.Append(ResName);
      sb.Append(",Pos: ");
      sb.Append(Pos== null ? "<null>" : Pos.ToString());
      sb.Append(",Rot: ");
      sb.Append(Rot== null ? "<null>" : Rot.ToString());
      sb.Append(",Scale: ");
      sb.Append(Scale== null ? "<null>" : Scale.ToString());
      sb.Append(",TargetMethodId: ");
      sb.Append(TargetMethodId);
      sb.Append(",LimitMethodId: ");
      sb.Append(LimitMethodId);
      sb.Append(",EnterFuncMethodId: ");
      sb.Append(EnterFuncMethodId);
      sb.Append(",ExitFuncMethodId: ");
      sb.Append(ExitFuncMethodId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}

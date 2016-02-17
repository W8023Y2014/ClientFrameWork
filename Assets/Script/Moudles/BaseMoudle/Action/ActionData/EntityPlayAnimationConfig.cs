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

namespace ActionEditor
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class EntityPlayAnimationConfig : TBase
  {
    private EntityType _entityType;
    private string _animName;
    private int _charId;

    /// <summary>
    /// 
    /// <seealso cref="EntityType"/>
    /// </summary>
    public EntityType EntityType
    {
      get
      {
        return _entityType;
      }
      set
      {
        __isset.entityType = true;
        this._entityType = value;
      }
    }

    public string AnimName
    {
      get
      {
        return _animName;
      }
      set
      {
        __isset.animName = true;
        this._animName = value;
      }
    }

    public int CharId
    {
      get
      {
        return _charId;
      }
      set
      {
        __isset.charId = true;
        this._charId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool entityType;
      public bool animName;
      public bool charId;
    }

    public EntityPlayAnimationConfig() {
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
          case 10:
            if (field.Type == TType.I32) {
              EntityType = (EntityType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.String) {
              AnimName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              CharId = iprot.ReadI32();
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
      TStruct struc = new TStruct("EntityPlayAnimationConfig");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.entityType) {
        field.Name = "entityType";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)EntityType);
        oprot.WriteFieldEnd();
      }
      if (AnimName != null && __isset.animName) {
        field.Name = "animName";
        field.Type = TType.String;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AnimName);
        oprot.WriteFieldEnd();
      }
      if (__isset.charId) {
        field.Name = "charId";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(CharId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("EntityPlayAnimationConfig(");
      sb.Append("EntityType: ");
      sb.Append(EntityType);
      sb.Append(",AnimName: ");
      sb.Append(AnimName);
      sb.Append(",CharId: ");
      sb.Append(CharId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}

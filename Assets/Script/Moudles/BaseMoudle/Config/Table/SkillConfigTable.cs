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

namespace Config.Table
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SkillConfigTable : TBase
  {
    private Dictionary<int, Config.SkillConfig> _skillConfigMap;

    public Dictionary<int, Config.SkillConfig> SkillConfigMap
    {
      get
      {
        return _skillConfigMap;
      }
      set
      {
        __isset.skillConfigMap = true;
        this._skillConfigMap = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool skillConfigMap;
    }

    public SkillConfigTable() {
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
            if (field.Type == TType.Map) {
              {
                SkillConfigMap = new Dictionary<int, Config.SkillConfig>();
                TMap _map69 = iprot.ReadMapBegin();
                for( int _i70 = 0; _i70 < _map69.Count; ++_i70)
                {
                  int _key71;
                  Config.SkillConfig _val72;
                  _key71 = iprot.ReadI32();
                  _val72 = new Config.SkillConfig();
                  _val72.Read(iprot);
                  SkillConfigMap[_key71] = _val72;
                }
                iprot.ReadMapEnd();
              }
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
      TStruct struc = new TStruct("SkillConfigTable");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (SkillConfigMap != null && __isset.skillConfigMap) {
        field.Name = "skillConfigMap";
        field.Type = TType.Map;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.I32, TType.Struct, SkillConfigMap.Count));
          foreach (int _iter73 in SkillConfigMap.Keys)
          {
            oprot.WriteI32(_iter73);
            SkillConfigMap[_iter73].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SkillConfigTable(");
      sb.Append("SkillConfigMap: ");
      sb.Append(SkillConfigMap);
      sb.Append(")");
      return sb.ToString();
    }

  }

}

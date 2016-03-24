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
  public partial class RunnerGameSettingTable : TBase
  {
    private double _initSpeed;
    private double _gravity;
    private double _jumpSpeed;
    private double _jumpStartRiseTime;
    private double _jumpEndDelayTime;

    public double InitSpeed
    {
      get
      {
        return _initSpeed;
      }
      set
      {
        __isset.initSpeed = true;
        this._initSpeed = value;
      }
    }

    public double Gravity
    {
      get
      {
        return _gravity;
      }
      set
      {
        __isset.gravity = true;
        this._gravity = value;
      }
    }

    public double JumpSpeed
    {
      get
      {
        return _jumpSpeed;
      }
      set
      {
        __isset.jumpSpeed = true;
        this._jumpSpeed = value;
      }
    }

    public double JumpStartRiseTime
    {
      get
      {
        return _jumpStartRiseTime;
      }
      set
      {
        __isset.jumpStartRiseTime = true;
        this._jumpStartRiseTime = value;
      }
    }

    public double JumpEndDelayTime
    {
      get
      {
        return _jumpEndDelayTime;
      }
      set
      {
        __isset.jumpEndDelayTime = true;
        this._jumpEndDelayTime = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool initSpeed;
      public bool gravity;
      public bool jumpSpeed;
      public bool jumpStartRiseTime;
      public bool jumpEndDelayTime;
    }

    public RunnerGameSettingTable() {
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
            if (field.Type == TType.Double) {
              InitSpeed = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Double) {
              Gravity = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Double) {
              JumpSpeed = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Double) {
              JumpStartRiseTime = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Double) {
              JumpEndDelayTime = iprot.ReadDouble();
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
      TStruct struc = new TStruct("RunnerGameSettingTable");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.initSpeed) {
        field.Name = "initSpeed";
        field.Type = TType.Double;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(InitSpeed);
        oprot.WriteFieldEnd();
      }
      if (__isset.gravity) {
        field.Name = "gravity";
        field.Type = TType.Double;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Gravity);
        oprot.WriteFieldEnd();
      }
      if (__isset.jumpSpeed) {
        field.Name = "jumpSpeed";
        field.Type = TType.Double;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(JumpSpeed);
        oprot.WriteFieldEnd();
      }
      if (__isset.jumpStartRiseTime) {
        field.Name = "jumpStartRiseTime";
        field.Type = TType.Double;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(JumpStartRiseTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.jumpEndDelayTime) {
        field.Name = "jumpEndDelayTime";
        field.Type = TType.Double;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(JumpEndDelayTime);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RunnerGameSettingTable(");
      sb.Append("InitSpeed: ");
      sb.Append(InitSpeed);
      sb.Append(",Gravity: ");
      sb.Append(Gravity);
      sb.Append(",JumpSpeed: ");
      sb.Append(JumpSpeed);
      sb.Append(",JumpStartRiseTime: ");
      sb.Append(JumpStartRiseTime);
      sb.Append(",JumpEndDelayTime: ");
      sb.Append(JumpEndDelayTime);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
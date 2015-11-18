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
  public partial class ActionFrameData : TBase
  {
    private double _time;
    private int _type;
    private SetCameraFrameConfig _setCameraFrame;
    private MoveCameraFrameConfig _moveCameraFrame;
    private PlayAudioFrameConfig _playAudioFrame;
    private boolCommonConfig _boolFrame;
    private stringCommonConfig _stringFrame;
    private MoveTransformFrameConfig _moveTransformFrame;
    private Common.Auto.ThriftVector3 _vector3Frame;

    public double Time
    {
      get
      {
        return _time;
      }
      set
      {
        __isset.time = true;
        this._time = value;
      }
    }

    public int Type
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

    public SetCameraFrameConfig SetCameraFrame
    {
      get
      {
        return _setCameraFrame;
      }
      set
      {
        __isset.setCameraFrame = true;
        this._setCameraFrame = value;
      }
    }

    public MoveCameraFrameConfig MoveCameraFrame
    {
      get
      {
        return _moveCameraFrame;
      }
      set
      {
        __isset.moveCameraFrame = true;
        this._moveCameraFrame = value;
      }
    }

    public PlayAudioFrameConfig PlayAudioFrame
    {
      get
      {
        return _playAudioFrame;
      }
      set
      {
        __isset.playAudioFrame = true;
        this._playAudioFrame = value;
      }
    }

    public boolCommonConfig BoolFrame
    {
      get
      {
        return _boolFrame;
      }
      set
      {
        __isset.boolFrame = true;
        this._boolFrame = value;
      }
    }

    public stringCommonConfig StringFrame
    {
      get
      {
        return _stringFrame;
      }
      set
      {
        __isset.stringFrame = true;
        this._stringFrame = value;
      }
    }

    public MoveTransformFrameConfig MoveTransformFrame
    {
      get
      {
        return _moveTransformFrame;
      }
      set
      {
        __isset.moveTransformFrame = true;
        this._moveTransformFrame = value;
      }
    }

    public Common.Auto.ThriftVector3 Vector3Frame
    {
      get
      {
        return _vector3Frame;
      }
      set
      {
        __isset.vector3Frame = true;
        this._vector3Frame = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool time;
      public bool type;
      public bool setCameraFrame;
      public bool moveCameraFrame;
      public bool playAudioFrame;
      public bool boolFrame;
      public bool stringFrame;
      public bool moveTransformFrame;
      public bool vector3Frame;
    }

    public ActionFrameData() {
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
              Time = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Type = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Struct) {
              SetCameraFrame = new SetCameraFrameConfig();
              SetCameraFrame.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Struct) {
              MoveCameraFrame = new MoveCameraFrameConfig();
              MoveCameraFrame.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Struct) {
              PlayAudioFrame = new PlayAudioFrameConfig();
              PlayAudioFrame.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 101:
            if (field.Type == TType.Struct) {
              BoolFrame = new boolCommonConfig();
              BoolFrame.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 102:
            if (field.Type == TType.Struct) {
              StringFrame = new stringCommonConfig();
              StringFrame.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 103:
            if (field.Type == TType.Struct) {
              MoveTransformFrame = new MoveTransformFrameConfig();
              MoveTransformFrame.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 104:
            if (field.Type == TType.Struct) {
              Vector3Frame = new Common.Auto.ThriftVector3();
              Vector3Frame.Read(iprot);
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
      TStruct struc = new TStruct("ActionFrameData");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.time) {
        field.Name = "time";
        field.Type = TType.Double;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Time);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Type);
        oprot.WriteFieldEnd();
      }
      if (SetCameraFrame != null && __isset.setCameraFrame) {
        field.Name = "setCameraFrame";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        SetCameraFrame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (MoveCameraFrame != null && __isset.moveCameraFrame) {
        field.Name = "moveCameraFrame";
        field.Type = TType.Struct;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        MoveCameraFrame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (PlayAudioFrame != null && __isset.playAudioFrame) {
        field.Name = "playAudioFrame";
        field.Type = TType.Struct;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        PlayAudioFrame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (BoolFrame != null && __isset.boolFrame) {
        field.Name = "boolFrame";
        field.Type = TType.Struct;
        field.ID = 101;
        oprot.WriteFieldBegin(field);
        BoolFrame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (StringFrame != null && __isset.stringFrame) {
        field.Name = "stringFrame";
        field.Type = TType.Struct;
        field.ID = 102;
        oprot.WriteFieldBegin(field);
        StringFrame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (MoveTransformFrame != null && __isset.moveTransformFrame) {
        field.Name = "moveTransformFrame";
        field.Type = TType.Struct;
        field.ID = 103;
        oprot.WriteFieldBegin(field);
        MoveTransformFrame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Vector3Frame != null && __isset.vector3Frame) {
        field.Name = "vector3Frame";
        field.Type = TType.Struct;
        field.ID = 104;
        oprot.WriteFieldBegin(field);
        Vector3Frame.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ActionFrameData(");
      sb.Append("Time: ");
      sb.Append(Time);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",SetCameraFrame: ");
      sb.Append(SetCameraFrame== null ? "<null>" : SetCameraFrame.ToString());
      sb.Append(",MoveCameraFrame: ");
      sb.Append(MoveCameraFrame== null ? "<null>" : MoveCameraFrame.ToString());
      sb.Append(",PlayAudioFrame: ");
      sb.Append(PlayAudioFrame== null ? "<null>" : PlayAudioFrame.ToString());
      sb.Append(",BoolFrame: ");
      sb.Append(BoolFrame== null ? "<null>" : BoolFrame.ToString());
      sb.Append(",StringFrame: ");
      sb.Append(StringFrame== null ? "<null>" : StringFrame.ToString());
      sb.Append(",MoveTransformFrame: ");
      sb.Append(MoveTransformFrame== null ? "<null>" : MoveTransformFrame.ToString());
      sb.Append(",Vector3Frame: ");
      sb.Append(Vector3Frame== null ? "<null>" : Vector3Frame.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}

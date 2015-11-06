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
  public partial class ActionFileData : TBase
  {
    private int _iD;
    private string _fileName;
    private string _mapResName;
    private double _duration;
    private bool _loop;
    private List<ActionFrameData> _frameDatalist;

    public int ID
    {
      get
      {
        return _iD;
      }
      set
      {
        __isset.iD = true;
        this._iD = value;
      }
    }

    public string FileName
    {
      get
      {
        return _fileName;
      }
      set
      {
        __isset.fileName = true;
        this._fileName = value;
      }
    }

    public string MapResName
    {
      get
      {
        return _mapResName;
      }
      set
      {
        __isset.mapResName = true;
        this._mapResName = value;
      }
    }

    public double Duration
    {
      get
      {
        return _duration;
      }
      set
      {
        __isset.duration = true;
        this._duration = value;
      }
    }

    public bool Loop
    {
      get
      {
        return _loop;
      }
      set
      {
        __isset.loop = true;
        this._loop = value;
      }
    }

    public List<ActionFrameData> FrameDatalist
    {
      get
      {
        return _frameDatalist;
      }
      set
      {
        __isset.frameDatalist = true;
        this._frameDatalist = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool iD;
      public bool fileName;
      public bool mapResName;
      public bool duration;
      public bool loop;
      public bool frameDatalist;
    }

    public ActionFileData() {
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
              ID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              FileName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              MapResName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Double) {
              Duration = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              Loop = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.List) {
              {
                FrameDatalist = new List<ActionFrameData>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  ActionFrameData _elem2 = new ActionFrameData();
                  _elem2 = new ActionFrameData();
                  _elem2.Read(iprot);
                  FrameDatalist.Add(_elem2);
                }
                iprot.ReadListEnd();
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
      TStruct struc = new TStruct("ActionFileData");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.iD) {
        field.Name = "iD";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ID);
        oprot.WriteFieldEnd();
      }
      if (FileName != null && __isset.fileName) {
        field.Name = "fileName";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(FileName);
        oprot.WriteFieldEnd();
      }
      if (MapResName != null && __isset.mapResName) {
        field.Name = "mapResName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(MapResName);
        oprot.WriteFieldEnd();
      }
      if (__isset.duration) {
        field.Name = "duration";
        field.Type = TType.Double;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Duration);
        oprot.WriteFieldEnd();
      }
      if (__isset.loop) {
        field.Name = "loop";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Loop);
        oprot.WriteFieldEnd();
      }
      if (FrameDatalist != null && __isset.frameDatalist) {
        field.Name = "frameDatalist";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, FrameDatalist.Count));
          foreach (ActionFrameData _iter3 in FrameDatalist)
          {
            _iter3.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ActionFileData(");
      sb.Append("ID: ");
      sb.Append(ID);
      sb.Append(",FileName: ");
      sb.Append(FileName);
      sb.Append(",MapResName: ");
      sb.Append(MapResName);
      sb.Append(",Duration: ");
      sb.Append(Duration);
      sb.Append(",Loop: ");
      sb.Append(Loop);
      sb.Append(",FrameDatalist: ");
      sb.Append(FrameDatalist);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
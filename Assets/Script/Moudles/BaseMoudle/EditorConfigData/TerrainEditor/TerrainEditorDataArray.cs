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
  public partial class TerrainEditorDataArray : TBase
  {
    private List<TerrainEditorData> _dataList;

    public List<TerrainEditorData> DataList
    {
      get
      {
        return _dataList;
      }
      set
      {
        __isset.dataList = true;
        this._dataList = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool dataList;
    }

    public TerrainEditorDataArray() {
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
            if (field.Type == TType.List) {
              {
                DataList = new List<TerrainEditorData>();
                TList _list4 = iprot.ReadListBegin();
                for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                {
                  TerrainEditorData _elem6 = new TerrainEditorData();
                  _elem6 = new TerrainEditorData();
                  _elem6.Read(iprot);
                  DataList.Add(_elem6);
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
      TStruct struc = new TStruct("TerrainEditorDataArray");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (DataList != null && __isset.dataList) {
        field.Name = "dataList";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, DataList.Count));
          foreach (TerrainEditorData _iter7 in DataList)
          {
            _iter7.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TerrainEditorDataArray(");
      sb.Append("DataList: ");
      sb.Append(DataList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: s2clientprotocol/error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SC2APIProtocol {

  /// <summary>Holder for reflection information generated from s2clientprotocol/error.proto</summary>
  public static partial class ErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for s2clientprotocol/error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxzMmNsaWVudHByb3RvY29sL2Vycm9yLnByb3RvEg5TQzJBUElQcm90b2Nv",
            "bCqoLQoMQWN0aW9uUmVzdWx0EgsKB1N1Y2Nlc3MQARIQCgxOb3RTdXBwb3J0",
            "ZWQQAhIJCgVFcnJvchADEhYKEkNhbnRRdWV1ZVRoYXRPcmRlchAEEgkKBVJl",
            "dHJ5EAUSDAoIQ29vbGRvd24QBhIPCgtRdWV1ZUlzRnVsbBAHEhQKEFJhbGx5",
            "UXVldWVJc0Z1bGwQCBIVChFOb3RFbm91Z2hNaW5lcmFscxAJEhQKEE5vdEVu",
            "b3VnaFZlc3BlbmUQChIWChJOb3RFbm91Z2hUZXJyYXppbmUQCxITCg9Ob3RF",
            "bm91Z2hDdXN0b20QDBIRCg1Ob3RFbm91Z2hGb29kEA0SFwoTRm9vZFVzYWdl",
            "SW1wb3NzaWJsZRAOEhEKDU5vdEVub3VnaExpZmUQDxIUChBOb3RFbm91Z2hT",
            "aGllbGRzEBASEwoPTm90RW5vdWdoRW5lcmd5EBESEgoOTGlmZVN1cHByZXNz",
            "ZWQQEhIVChFTaGllbGRzU3VwcHJlc3NlZBATEhQKEEVuZXJneVN1cHByZXNz",
            "ZWQQFBIUChBOb3RFbm91Z2hDaGFyZ2VzEBUSFgoSQ2FudEFkZE1vcmVDaGFy",
            "Z2VzEBYSEwoPVG9vTXVjaE1pbmVyYWxzEBcSEgoOVG9vTXVjaFZlc3BlbmUQ",
            "GBIUChBUb29NdWNoVGVycmF6aW5lEBkSEQoNVG9vTXVjaEN1c3RvbRAaEg8K",
            "C1Rvb011Y2hGb29kEBsSDwoLVG9vTXVjaExpZmUQHBISCg5Ub29NdWNoU2hp",
            "ZWxkcxAdEhEKDVRvb011Y2hFbmVyZ3kQHhIaChZNdXN0VGFyZ2V0VW5pdFdp",
            "dGhMaWZlEB8SHQoZTXVzdFRhcmdldFVuaXRXaXRoU2hpZWxkcxAgEhwKGE11",
            "c3RUYXJnZXRVbml0V2l0aEVuZXJneRAhEg0KCUNhbnRUcmFkZRAiEg0KCUNh",
            "bnRTcGVuZBAjEhYKEkNhbnRUYXJnZXRUaGF0VW5pdBAkEhcKE0NvdWxkbnRB",
            "bGxvY2F0ZVVuaXQQJRIQCgxVbml0Q2FudE1vdmUQJhIeChpUcmFuc3BvcnRJ",
            "c0hvbGRpbmdQb3NpdGlvbhAnEh8KG0J1aWxkVGVjaFJlcXVpcmVtZW50c05v",
            "dE1ldBAoEh0KGUNhbnRGaW5kUGxhY2VtZW50TG9jYXRpb24QKRITCg9DYW50",
            "QnVpbGRPblRoYXQQKhIeChpDYW50QnVpbGRUb29DbG9zZVRvRHJvcE9mZhAr",
            "EhwKGENhbnRCdWlsZExvY2F0aW9uSW52YWxpZBAsEhgKFENhbnRTZWVCdWls",
            "ZExvY2F0aW9uEC0SIgoeQ2FudEJ1aWxkVG9vQ2xvc2VUb0NyZWVwU291cmNl",
            "EC4SIAocQ2FudEJ1aWxkVG9vQ2xvc2VUb1Jlc291cmNlcxAvEhwKGENhbnRC",
            "dWlsZFRvb0ZhckZyb21XYXRlchAwEiIKHkNhbnRCdWlsZFRvb0ZhckZyb21D",
            "cmVlcFNvdXJjZRAxEicKI0NhbnRCdWlsZFRvb0ZhckZyb21CdWlsZFBvd2Vy",
            "U291cmNlEDISGwoXQ2FudEJ1aWxkT25EZW5zZVRlcnJhaW4QMxInCiNDYW50",
            "VHJhaW5Ub29GYXJGcm9tVHJhaW5Qb3dlclNvdXJjZRA0EhsKF0NhbnRMYW5k",
            "TG9jYXRpb25JbnZhbGlkEDUSFwoTQ2FudFNlZUxhbmRMb2NhdGlvbhA2EiEK",
            "HUNhbnRMYW5kVG9vQ2xvc2VUb0NyZWVwU291cmNlEDcSHwobQ2FudExhbmRU",
            "b29DbG9zZVRvUmVzb3VyY2VzEDgSGwoXQ2FudExhbmRUb29GYXJGcm9tV2F0",
            "ZXIQORIhCh1DYW50TGFuZFRvb0ZhckZyb21DcmVlcFNvdXJjZRA6EiYKIkNh",
            "bnRMYW5kVG9vRmFyRnJvbUJ1aWxkUG93ZXJTb3VyY2UQOxImCiJDYW50TGFu",
            "ZFRvb0ZhckZyb21UcmFpblBvd2VyU291cmNlEDwSGgoWQ2FudExhbmRPbkRl",
            "bnNlVGVycmFpbhA9EhsKF0FkZE9uVG9vRmFyRnJvbUJ1aWxkaW5nED4SGgoW",
            "TXVzdEJ1aWxkUmVmaW5lcnlGaXJzdBA/Eh8KG0J1aWxkaW5nSXNVbmRlckNv",
            "bnN0cnVjdGlvbhBAEhMKD0NhbnRGaW5kRHJvcE9mZhBBEh0KGUNhbnRMb2Fk",
            "T3RoZXJQbGF5ZXJzVW5pdHMQQhIbChdOb3RFbm91Z2hSb29tVG9Mb2FkVW5p",
            "dBBDEhgKFENhbnRVbmxvYWRVbml0c1RoZXJlEEQSGAoUQ2FudFdhcnBJblVu",
            "aXRzVGhlcmUQRRIZChVDYW50TG9hZEltbW9iaWxlVW5pdHMQRhIdChlDYW50",
            "UmVjaGFyZ2VJbW1vYmlsZVVuaXRzEEcSJgoiQ2FudFJlY2hhcmdlVW5kZXJD",
            "b25zdHJ1Y3Rpb25Vbml0cxBIEhQKEENhbnRMb2FkVGhhdFVuaXQQSRITCg9O",
            "b0NhcmdvVG9VbmxvYWQQShIZChVMb2FkQWxsTm9UYXJnZXRzRm91bmQQSxIU",
            "ChBOb3RXaGlsZU9jY3VwaWVkEEwSGQoVQ2FudEF0dGFja1dpdGhvdXRBbW1v",
            "EE0SFwoTQ2FudEhvbGRBbnlNb3JlQW1tbxBOEhoKFlRlY2hSZXF1aXJlbWVu",
            "dHNOb3RNZXQQTxIZChVNdXN0TG9ja2Rvd25Vbml0Rmlyc3QQUBISCg5NdXN0",
            "VGFyZ2V0VW5pdBBREhcKE011c3RUYXJnZXRJbnZlbnRvcnkQUhIZChVNdXN0",
            "VGFyZ2V0VmlzaWJsZVVuaXQQUxIdChlNdXN0VGFyZ2V0VmlzaWJsZUxvY2F0",
            "aW9uEFQSHgoaTXVzdFRhcmdldFdhbGthYmxlTG9jYXRpb24QVRIaChZNdXN0",
            "VGFyZ2V0UGF3bmFibGVVbml0EFYSGgoWWW91Q2FudENvbnRyb2xUaGF0VW5p",
            "dBBXEiIKHllvdUNhbnRJc3N1ZUNvbW1hbmRzVG9UaGF0VW5pdBBYEhcKE011",
            "c3RUYXJnZXRSZXNvdXJjZXMQWRIWChJSZXF1aXJlc0hlYWxUYXJnZXQQWhIY",
            "ChRSZXF1aXJlc1JlcGFpclRhcmdldBBbEhEKDU5vSXRlbXNUb0Ryb3AQXBIY",
            "ChRDYW50SG9sZEFueU1vcmVJdGVtcxBdEhAKDENhbnRIb2xkVGhhdBBeEhgK",
            "FFRhcmdldEhhc05vSW52ZW50b3J5EF8SFAoQQ2FudERyb3BUaGlzSXRlbRBg",
            "EhQKEENhbnRNb3ZlVGhpc0l0ZW0QYRIUChBDYW50UGF3blRoaXNVbml0EGIS",
            "FAoQTXVzdFRhcmdldENhc3RlchBjEhQKEENhbnRUYXJnZXRDYXN0ZXIQZBIT",
            "Cg9NdXN0VGFyZ2V0T3V0ZXIQZRITCg9DYW50VGFyZ2V0T3V0ZXIQZhIaChZN",
            "dXN0VGFyZ2V0WW91ck93blVuaXRzEGcSGgoWQ2FudFRhcmdldFlvdXJPd25V",
            "bml0cxBoEhsKF011c3RUYXJnZXRGcmllbmRseVVuaXRzEGkSGwoXQ2FudFRh",
            "cmdldEZyaWVuZGx5VW5pdHMQahIaChZNdXN0VGFyZ2V0TmV1dHJhbFVuaXRz",
            "EGsSGgoWQ2FudFRhcmdldE5ldXRyYWxVbml0cxBsEhgKFE11c3RUYXJnZXRF",
            "bmVteVVuaXRzEG0SGAoUQ2FudFRhcmdldEVuZW15VW5pdHMQbhIWChJNdXN0",
            "VGFyZ2V0QWlyVW5pdHMQbxIWChJDYW50VGFyZ2V0QWlyVW5pdHMQcBIZChVN",
            "dXN0VGFyZ2V0R3JvdW5kVW5pdHMQcRIZChVDYW50VGFyZ2V0R3JvdW5kVW5p",
            "dHMQchIYChRNdXN0VGFyZ2V0U3RydWN0dXJlcxBzEhgKFENhbnRUYXJnZXRT",
            "dHJ1Y3R1cmVzEHQSGAoUTXVzdFRhcmdldExpZ2h0VW5pdHMQdRIYChRDYW50",
            "VGFyZ2V0TGlnaHRVbml0cxB2EhoKFk11c3RUYXJnZXRBcm1vcmVkVW5pdHMQ",
            "dxIaChZDYW50VGFyZ2V0QXJtb3JlZFVuaXRzEHgSHQoZTXVzdFRhcmdldEJp",
            "b2xvZ2ljYWxVbml0cxB5Eh0KGUNhbnRUYXJnZXRCaW9sb2dpY2FsVW5pdHMQ",
            "ehIZChVNdXN0VGFyZ2V0SGVyb2ljVW5pdHMQexIZChVDYW50VGFyZ2V0SGVy",
            "b2ljVW5pdHMQfBIaChZNdXN0VGFyZ2V0Um9ib3RpY1VuaXRzEH0SGgoWQ2Fu",
            "dFRhcmdldFJvYm90aWNVbml0cxB+Eh0KGU11c3RUYXJnZXRNZWNoYW5pY2Fs",
            "VW5pdHMQfxIeChlDYW50VGFyZ2V0TWVjaGFuaWNhbFVuaXRzEIABEhsKFk11",
            "c3RUYXJnZXRQc2lvbmljVW5pdHMQgQESGwoWQ2FudFRhcmdldFBzaW9uaWNV",
            "bml0cxCCARIbChZNdXN0VGFyZ2V0TWFzc2l2ZVVuaXRzEIMBEhsKFkNhbnRU",
            "YXJnZXRNYXNzaXZlVW5pdHMQhAESFgoRTXVzdFRhcmdldE1pc3NpbGUQhQES",
            "FgoRQ2FudFRhcmdldE1pc3NpbGUQhgESGgoVTXVzdFRhcmdldFdvcmtlclVu",
            "aXRzEIcBEhoKFUNhbnRUYXJnZXRXb3JrZXJVbml0cxCIARIhChxNdXN0VGFy",
            "Z2V0RW5lcmd5Q2FwYWJsZVVuaXRzEIkBEiEKHENhbnRUYXJnZXRFbmVyZ3lD",
            "YXBhYmxlVW5pdHMQigESIQocTXVzdFRhcmdldFNoaWVsZENhcGFibGVVbml0",
            "cxCLARIhChxDYW50VGFyZ2V0U2hpZWxkQ2FwYWJsZVVuaXRzEIwBEhUKEE11",
            "c3RUYXJnZXRGbHllcnMQjQESFQoQQ2FudFRhcmdldEZseWVycxCOARIaChVN",
            "dXN0VGFyZ2V0QnVyaWVkVW5pdHMQjwESGgoVQ2FudFRhcmdldEJ1cmllZFVu",
            "aXRzEJABEhsKFk11c3RUYXJnZXRDbG9ha2VkVW5pdHMQkQESGwoWQ2FudFRh",
            "cmdldENsb2FrZWRVbml0cxCSARIiCh1NdXN0VGFyZ2V0VW5pdHNJbkFTdGFz",
            "aXNGaWVsZBCTARIiCh1DYW50VGFyZ2V0VW5pdHNJbkFTdGFzaXNGaWVsZBCU",
            "ARIlCiBNdXN0VGFyZ2V0VW5kZXJDb25zdHJ1Y3Rpb25Vbml0cxCVARIlCiBD",
            "YW50VGFyZ2V0VW5kZXJDb25zdHJ1Y3Rpb25Vbml0cxCWARIYChNNdXN0VGFy",
            "Z2V0RGVhZFVuaXRzEJcBEhgKE0NhbnRUYXJnZXREZWFkVW5pdHMQmAESHQoY",
            "TXVzdFRhcmdldFJldml2YWJsZVVuaXRzEJkBEh0KGENhbnRUYXJnZXRSZXZp",
            "dmFibGVVbml0cxCaARIaChVNdXN0VGFyZ2V0SGlkZGVuVW5pdHMQmwESGgoV",
            "Q2FudFRhcmdldEhpZGRlblVuaXRzEJwBEiIKHUNhbnRSZWNoYXJnZU90aGVy",
            "UGxheWVyc1VuaXRzEJ0BEh0KGE11c3RUYXJnZXRIYWxsdWNpbmF0aW9ucxCe",
            "ARIdChhDYW50VGFyZ2V0SGFsbHVjaW5hdGlvbnMQnwESIAobTXVzdFRhcmdl",
            "dEludnVsbmVyYWJsZVVuaXRzEKABEiAKG0NhbnRUYXJnZXRJbnZ1bG5lcmFi",
            "bGVVbml0cxChARIcChdNdXN0VGFyZ2V0RGV0ZWN0ZWRVbml0cxCiARIcChdD",
            "YW50VGFyZ2V0RGV0ZWN0ZWRVbml0cxCjARIdChhDYW50VGFyZ2V0VW5pdFdp",
            "dGhFbmVyZ3kQpAESHgoZQ2FudFRhcmdldFVuaXRXaXRoU2hpZWxkcxClARIh",
            "ChxNdXN0VGFyZ2V0VW5jb21tYW5kYWJsZVVuaXRzEKYBEiEKHENhbnRUYXJn",
            "ZXRVbmNvbW1hbmRhYmxlVW5pdHMQpwESIQocTXVzdFRhcmdldFByZXZlbnRE",
            "ZWZlYXRVbml0cxCoARIhChxDYW50VGFyZ2V0UHJldmVudERlZmVhdFVuaXRz",
            "EKkBEiEKHE11c3RUYXJnZXRQcmV2ZW50UmV2ZWFsVW5pdHMQqgESIQocQ2Fu",
            "dFRhcmdldFByZXZlbnRSZXZlYWxVbml0cxCrARIbChZNdXN0VGFyZ2V0UGFz",
            "c2l2ZVVuaXRzEKwBEhsKFkNhbnRUYXJnZXRQYXNzaXZlVW5pdHMQrQESGwoW",
            "TXVzdFRhcmdldFN0dW5uZWRVbml0cxCuARIbChZDYW50VGFyZ2V0U3R1bm5l",
            "ZFVuaXRzEK8BEhwKF011c3RUYXJnZXRTdW1tb25lZFVuaXRzELABEhwKF0Nh",
            "bnRUYXJnZXRTdW1tb25lZFVuaXRzELEBEhQKD011c3RUYXJnZXRVc2VyMRCy",
            "ARIUCg9DYW50VGFyZ2V0VXNlcjEQswESHwoaTXVzdFRhcmdldFVuc3RvcHBh",
            "YmxlVW5pdHMQtAESHwoaQ2FudFRhcmdldFVuc3RvcHBhYmxlVW5pdHMQtQES",
            "HQoYTXVzdFRhcmdldFJlc2lzdGFudFVuaXRzELYBEh0KGENhbnRUYXJnZXRS",
            "ZXNpc3RhbnRVbml0cxC3ARIZChRNdXN0VGFyZ2V0RGF6ZWRVbml0cxC4ARIZ",
            "ChRDYW50VGFyZ2V0RGF6ZWRVbml0cxC5ARIRCgxDYW50TG9ja2Rvd24QugES",
            "FAoPQ2FudE1pbmRDb250cm9sELsBEhwKF011c3RUYXJnZXREZXN0cnVjdGli",
            "bGVzELwBEhwKF0NhbnRUYXJnZXREZXN0cnVjdGlibGVzEL0BEhQKD011c3RU",
            "YXJnZXRJdGVtcxC+ARIUCg9DYW50VGFyZ2V0SXRlbXMQvwESGAoTTm9DYWxs",
            "ZG93bkF2YWlsYWJsZRDAARIVChBXYXlwb2ludExpc3RGdWxsEMEBEhMKDk11",
            "c3RUYXJnZXRSYWNlEMIBEhMKDkNhbnRUYXJnZXRSYWNlEMMBEhsKFk11c3RU",
            "YXJnZXRTaW1pbGFyVW5pdHMQxAESGwoWQ2FudFRhcmdldFNpbWlsYXJVbml0",
            "cxDFARIaChVDYW50RmluZEVub3VnaFRhcmdldHMQxgESGQoUQWxyZWFkeVNw",
            "YXduaW5nTGFydmEQxwESIQocQ2FudFRhcmdldEV4aGF1c3RlZFJlc291cmNl",
            "cxDIARITCg5DYW50VXNlTWluaW1hcBDJARIVChBDYW50VXNlSW5mb1BhbmVs",
            "EMoBEhUKEE9yZGVyUXVldWVJc0Z1bGwQywESHAoXQ2FudEhhcnZlc3RUaGF0",
            "UmVzb3VyY2UQzAESGgoVSGFydmVzdGVyc05vdFJlcXVpcmVkEM0BEhQKD0Fs",
            "cmVhZHlUYXJnZXRlZBDOARIeChlDYW50QXR0YWNrV2VhcG9uc0Rpc2FibGVk",
            "EM8BEhcKEkNvdWxkbnRSZWFjaFRhcmdldBDQARIXChJUYXJnZXRJc091dE9m",
            "UmFuZ2UQ0QESFQoQVGFyZ2V0SXNUb29DbG9zZRDSARIVChBUYXJnZXRJc091",
            "dE9mQXJjENMBEh0KGENhbnRGaW5kVGVsZXBvcnRMb2NhdGlvbhDUARIVChBJ",
            "bnZhbGlkSXRlbUNsYXNzENUBEhgKE0NhbnRGaW5kQ2FuY2VsT3JkZXIQ1gE="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::SC2APIProtocol.ActionResult), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ActionResult {
    [pbr::OriginalName("Success")] Success = 1,
    [pbr::OriginalName("NotSupported")] NotSupported = 2,
    [pbr::OriginalName("Error")] Error = 3,
    [pbr::OriginalName("CantQueueThatOrder")] CantQueueThatOrder = 4,
    [pbr::OriginalName("Retry")] Retry = 5,
    [pbr::OriginalName("Cooldown")] Cooldown = 6,
    [pbr::OriginalName("QueueIsFull")] QueueIsFull = 7,
    [pbr::OriginalName("RallyQueueIsFull")] RallyQueueIsFull = 8,
    [pbr::OriginalName("NotEnoughMinerals")] NotEnoughMinerals = 9,
    [pbr::OriginalName("NotEnoughVespene")] NotEnoughVespene = 10,
    [pbr::OriginalName("NotEnoughTerrazine")] NotEnoughTerrazine = 11,
    [pbr::OriginalName("NotEnoughCustom")] NotEnoughCustom = 12,
    [pbr::OriginalName("NotEnoughFood")] NotEnoughFood = 13,
    [pbr::OriginalName("FoodUsageImpossible")] FoodUsageImpossible = 14,
    [pbr::OriginalName("NotEnoughLife")] NotEnoughLife = 15,
    [pbr::OriginalName("NotEnoughShields")] NotEnoughShields = 16,
    [pbr::OriginalName("NotEnoughEnergy")] NotEnoughEnergy = 17,
    [pbr::OriginalName("LifeSuppressed")] LifeSuppressed = 18,
    [pbr::OriginalName("ShieldsSuppressed")] ShieldsSuppressed = 19,
    [pbr::OriginalName("EnergySuppressed")] EnergySuppressed = 20,
    [pbr::OriginalName("NotEnoughCharges")] NotEnoughCharges = 21,
    [pbr::OriginalName("CantAddMoreCharges")] CantAddMoreCharges = 22,
    [pbr::OriginalName("TooMuchMinerals")] TooMuchMinerals = 23,
    [pbr::OriginalName("TooMuchVespene")] TooMuchVespene = 24,
    [pbr::OriginalName("TooMuchTerrazine")] TooMuchTerrazine = 25,
    [pbr::OriginalName("TooMuchCustom")] TooMuchCustom = 26,
    [pbr::OriginalName("TooMuchFood")] TooMuchFood = 27,
    [pbr::OriginalName("TooMuchLife")] TooMuchLife = 28,
    [pbr::OriginalName("TooMuchShields")] TooMuchShields = 29,
    [pbr::OriginalName("TooMuchEnergy")] TooMuchEnergy = 30,
    [pbr::OriginalName("MustTargetUnitWithLife")] MustTargetUnitWithLife = 31,
    [pbr::OriginalName("MustTargetUnitWithShields")] MustTargetUnitWithShields = 32,
    [pbr::OriginalName("MustTargetUnitWithEnergy")] MustTargetUnitWithEnergy = 33,
    [pbr::OriginalName("CantTrade")] CantTrade = 34,
    [pbr::OriginalName("CantSpend")] CantSpend = 35,
    [pbr::OriginalName("CantTargetThatUnit")] CantTargetThatUnit = 36,
    [pbr::OriginalName("CouldntAllocateUnit")] CouldntAllocateUnit = 37,
    [pbr::OriginalName("UnitCantMove")] UnitCantMove = 38,
    [pbr::OriginalName("TransportIsHoldingPosition")] TransportIsHoldingPosition = 39,
    [pbr::OriginalName("BuildTechRequirementsNotMet")] BuildTechRequirementsNotMet = 40,
    [pbr::OriginalName("CantFindPlacementLocation")] CantFindPlacementLocation = 41,
    [pbr::OriginalName("CantBuildOnThat")] CantBuildOnThat = 42,
    [pbr::OriginalName("CantBuildTooCloseToDropOff")] CantBuildTooCloseToDropOff = 43,
    [pbr::OriginalName("CantBuildLocationInvalid")] CantBuildLocationInvalid = 44,
    [pbr::OriginalName("CantSeeBuildLocation")] CantSeeBuildLocation = 45,
    [pbr::OriginalName("CantBuildTooCloseToCreepSource")] CantBuildTooCloseToCreepSource = 46,
    [pbr::OriginalName("CantBuildTooCloseToResources")] CantBuildTooCloseToResources = 47,
    [pbr::OriginalName("CantBuildTooFarFromWater")] CantBuildTooFarFromWater = 48,
    [pbr::OriginalName("CantBuildTooFarFromCreepSource")] CantBuildTooFarFromCreepSource = 49,
    [pbr::OriginalName("CantBuildTooFarFromBuildPowerSource")] CantBuildTooFarFromBuildPowerSource = 50,
    [pbr::OriginalName("CantBuildOnDenseTerrain")] CantBuildOnDenseTerrain = 51,
    [pbr::OriginalName("CantTrainTooFarFromTrainPowerSource")] CantTrainTooFarFromTrainPowerSource = 52,
    [pbr::OriginalName("CantLandLocationInvalid")] CantLandLocationInvalid = 53,
    [pbr::OriginalName("CantSeeLandLocation")] CantSeeLandLocation = 54,
    [pbr::OriginalName("CantLandTooCloseToCreepSource")] CantLandTooCloseToCreepSource = 55,
    [pbr::OriginalName("CantLandTooCloseToResources")] CantLandTooCloseToResources = 56,
    [pbr::OriginalName("CantLandTooFarFromWater")] CantLandTooFarFromWater = 57,
    [pbr::OriginalName("CantLandTooFarFromCreepSource")] CantLandTooFarFromCreepSource = 58,
    [pbr::OriginalName("CantLandTooFarFromBuildPowerSource")] CantLandTooFarFromBuildPowerSource = 59,
    [pbr::OriginalName("CantLandTooFarFromTrainPowerSource")] CantLandTooFarFromTrainPowerSource = 60,
    [pbr::OriginalName("CantLandOnDenseTerrain")] CantLandOnDenseTerrain = 61,
    [pbr::OriginalName("AddOnTooFarFromBuilding")] AddOnTooFarFromBuilding = 62,
    [pbr::OriginalName("MustBuildRefineryFirst")] MustBuildRefineryFirst = 63,
    [pbr::OriginalName("BuildingIsUnderConstruction")] BuildingIsUnderConstruction = 64,
    [pbr::OriginalName("CantFindDropOff")] CantFindDropOff = 65,
    [pbr::OriginalName("CantLoadOtherPlayersUnits")] CantLoadOtherPlayersUnits = 66,
    [pbr::OriginalName("NotEnoughRoomToLoadUnit")] NotEnoughRoomToLoadUnit = 67,
    [pbr::OriginalName("CantUnloadUnitsThere")] CantUnloadUnitsThere = 68,
    [pbr::OriginalName("CantWarpInUnitsThere")] CantWarpInUnitsThere = 69,
    [pbr::OriginalName("CantLoadImmobileUnits")] CantLoadImmobileUnits = 70,
    [pbr::OriginalName("CantRechargeImmobileUnits")] CantRechargeImmobileUnits = 71,
    [pbr::OriginalName("CantRechargeUnderConstructionUnits")] CantRechargeUnderConstructionUnits = 72,
    [pbr::OriginalName("CantLoadThatUnit")] CantLoadThatUnit = 73,
    [pbr::OriginalName("NoCargoToUnload")] NoCargoToUnload = 74,
    [pbr::OriginalName("LoadAllNoTargetsFound")] LoadAllNoTargetsFound = 75,
    [pbr::OriginalName("NotWhileOccupied")] NotWhileOccupied = 76,
    [pbr::OriginalName("CantAttackWithoutAmmo")] CantAttackWithoutAmmo = 77,
    [pbr::OriginalName("CantHoldAnyMoreAmmo")] CantHoldAnyMoreAmmo = 78,
    [pbr::OriginalName("TechRequirementsNotMet")] TechRequirementsNotMet = 79,
    [pbr::OriginalName("MustLockdownUnitFirst")] MustLockdownUnitFirst = 80,
    [pbr::OriginalName("MustTargetUnit")] MustTargetUnit = 81,
    [pbr::OriginalName("MustTargetInventory")] MustTargetInventory = 82,
    [pbr::OriginalName("MustTargetVisibleUnit")] MustTargetVisibleUnit = 83,
    [pbr::OriginalName("MustTargetVisibleLocation")] MustTargetVisibleLocation = 84,
    [pbr::OriginalName("MustTargetWalkableLocation")] MustTargetWalkableLocation = 85,
    [pbr::OriginalName("MustTargetPawnableUnit")] MustTargetPawnableUnit = 86,
    [pbr::OriginalName("YouCantControlThatUnit")] YouCantControlThatUnit = 87,
    [pbr::OriginalName("YouCantIssueCommandsToThatUnit")] YouCantIssueCommandsToThatUnit = 88,
    [pbr::OriginalName("MustTargetResources")] MustTargetResources = 89,
    [pbr::OriginalName("RequiresHealTarget")] RequiresHealTarget = 90,
    [pbr::OriginalName("RequiresRepairTarget")] RequiresRepairTarget = 91,
    [pbr::OriginalName("NoItemsToDrop")] NoItemsToDrop = 92,
    [pbr::OriginalName("CantHoldAnyMoreItems")] CantHoldAnyMoreItems = 93,
    [pbr::OriginalName("CantHoldThat")] CantHoldThat = 94,
    [pbr::OriginalName("TargetHasNoInventory")] TargetHasNoInventory = 95,
    [pbr::OriginalName("CantDropThisItem")] CantDropThisItem = 96,
    [pbr::OriginalName("CantMoveThisItem")] CantMoveThisItem = 97,
    [pbr::OriginalName("CantPawnThisUnit")] CantPawnThisUnit = 98,
    [pbr::OriginalName("MustTargetCaster")] MustTargetCaster = 99,
    [pbr::OriginalName("CantTargetCaster")] CantTargetCaster = 100,
    [pbr::OriginalName("MustTargetOuter")] MustTargetOuter = 101,
    [pbr::OriginalName("CantTargetOuter")] CantTargetOuter = 102,
    [pbr::OriginalName("MustTargetYourOwnUnits")] MustTargetYourOwnUnits = 103,
    [pbr::OriginalName("CantTargetYourOwnUnits")] CantTargetYourOwnUnits = 104,
    [pbr::OriginalName("MustTargetFriendlyUnits")] MustTargetFriendlyUnits = 105,
    [pbr::OriginalName("CantTargetFriendlyUnits")] CantTargetFriendlyUnits = 106,
    [pbr::OriginalName("MustTargetNeutralUnits")] MustTargetNeutralUnits = 107,
    [pbr::OriginalName("CantTargetNeutralUnits")] CantTargetNeutralUnits = 108,
    [pbr::OriginalName("MustTargetEnemyUnits")] MustTargetEnemyUnits = 109,
    [pbr::OriginalName("CantTargetEnemyUnits")] CantTargetEnemyUnits = 110,
    [pbr::OriginalName("MustTargetAirUnits")] MustTargetAirUnits = 111,
    [pbr::OriginalName("CantTargetAirUnits")] CantTargetAirUnits = 112,
    [pbr::OriginalName("MustTargetGroundUnits")] MustTargetGroundUnits = 113,
    [pbr::OriginalName("CantTargetGroundUnits")] CantTargetGroundUnits = 114,
    [pbr::OriginalName("MustTargetStructures")] MustTargetStructures = 115,
    [pbr::OriginalName("CantTargetStructures")] CantTargetStructures = 116,
    [pbr::OriginalName("MustTargetLightUnits")] MustTargetLightUnits = 117,
    [pbr::OriginalName("CantTargetLightUnits")] CantTargetLightUnits = 118,
    [pbr::OriginalName("MustTargetArmoredUnits")] MustTargetArmoredUnits = 119,
    [pbr::OriginalName("CantTargetArmoredUnits")] CantTargetArmoredUnits = 120,
    [pbr::OriginalName("MustTargetBiologicalUnits")] MustTargetBiologicalUnits = 121,
    [pbr::OriginalName("CantTargetBiologicalUnits")] CantTargetBiologicalUnits = 122,
    [pbr::OriginalName("MustTargetHeroicUnits")] MustTargetHeroicUnits = 123,
    [pbr::OriginalName("CantTargetHeroicUnits")] CantTargetHeroicUnits = 124,
    [pbr::OriginalName("MustTargetRoboticUnits")] MustTargetRoboticUnits = 125,
    [pbr::OriginalName("CantTargetRoboticUnits")] CantTargetRoboticUnits = 126,
    [pbr::OriginalName("MustTargetMechanicalUnits")] MustTargetMechanicalUnits = 127,
    [pbr::OriginalName("CantTargetMechanicalUnits")] CantTargetMechanicalUnits = 128,
    [pbr::OriginalName("MustTargetPsionicUnits")] MustTargetPsionicUnits = 129,
    [pbr::OriginalName("CantTargetPsionicUnits")] CantTargetPsionicUnits = 130,
    [pbr::OriginalName("MustTargetMassiveUnits")] MustTargetMassiveUnits = 131,
    [pbr::OriginalName("CantTargetMassiveUnits")] CantTargetMassiveUnits = 132,
    [pbr::OriginalName("MustTargetMissile")] MustTargetMissile = 133,
    [pbr::OriginalName("CantTargetMissile")] CantTargetMissile = 134,
    [pbr::OriginalName("MustTargetWorkerUnits")] MustTargetWorkerUnits = 135,
    [pbr::OriginalName("CantTargetWorkerUnits")] CantTargetWorkerUnits = 136,
    [pbr::OriginalName("MustTargetEnergyCapableUnits")] MustTargetEnergyCapableUnits = 137,
    [pbr::OriginalName("CantTargetEnergyCapableUnits")] CantTargetEnergyCapableUnits = 138,
    [pbr::OriginalName("MustTargetShieldCapableUnits")] MustTargetShieldCapableUnits = 139,
    [pbr::OriginalName("CantTargetShieldCapableUnits")] CantTargetShieldCapableUnits = 140,
    [pbr::OriginalName("MustTargetFlyers")] MustTargetFlyers = 141,
    [pbr::OriginalName("CantTargetFlyers")] CantTargetFlyers = 142,
    [pbr::OriginalName("MustTargetBuriedUnits")] MustTargetBuriedUnits = 143,
    [pbr::OriginalName("CantTargetBuriedUnits")] CantTargetBuriedUnits = 144,
    [pbr::OriginalName("MustTargetCloakedUnits")] MustTargetCloakedUnits = 145,
    [pbr::OriginalName("CantTargetCloakedUnits")] CantTargetCloakedUnits = 146,
    [pbr::OriginalName("MustTargetUnitsInAStasisField")] MustTargetUnitsInAstasisField = 147,
    [pbr::OriginalName("CantTargetUnitsInAStasisField")] CantTargetUnitsInAstasisField = 148,
    [pbr::OriginalName("MustTargetUnderConstructionUnits")] MustTargetUnderConstructionUnits = 149,
    [pbr::OriginalName("CantTargetUnderConstructionUnits")] CantTargetUnderConstructionUnits = 150,
    [pbr::OriginalName("MustTargetDeadUnits")] MustTargetDeadUnits = 151,
    [pbr::OriginalName("CantTargetDeadUnits")] CantTargetDeadUnits = 152,
    [pbr::OriginalName("MustTargetRevivableUnits")] MustTargetRevivableUnits = 153,
    [pbr::OriginalName("CantTargetRevivableUnits")] CantTargetRevivableUnits = 154,
    [pbr::OriginalName("MustTargetHiddenUnits")] MustTargetHiddenUnits = 155,
    [pbr::OriginalName("CantTargetHiddenUnits")] CantTargetHiddenUnits = 156,
    [pbr::OriginalName("CantRechargeOtherPlayersUnits")] CantRechargeOtherPlayersUnits = 157,
    [pbr::OriginalName("MustTargetHallucinations")] MustTargetHallucinations = 158,
    [pbr::OriginalName("CantTargetHallucinations")] CantTargetHallucinations = 159,
    [pbr::OriginalName("MustTargetInvulnerableUnits")] MustTargetInvulnerableUnits = 160,
    [pbr::OriginalName("CantTargetInvulnerableUnits")] CantTargetInvulnerableUnits = 161,
    [pbr::OriginalName("MustTargetDetectedUnits")] MustTargetDetectedUnits = 162,
    [pbr::OriginalName("CantTargetDetectedUnits")] CantTargetDetectedUnits = 163,
    [pbr::OriginalName("CantTargetUnitWithEnergy")] CantTargetUnitWithEnergy = 164,
    [pbr::OriginalName("CantTargetUnitWithShields")] CantTargetUnitWithShields = 165,
    [pbr::OriginalName("MustTargetUncommandableUnits")] MustTargetUncommandableUnits = 166,
    [pbr::OriginalName("CantTargetUncommandableUnits")] CantTargetUncommandableUnits = 167,
    [pbr::OriginalName("MustTargetPreventDefeatUnits")] MustTargetPreventDefeatUnits = 168,
    [pbr::OriginalName("CantTargetPreventDefeatUnits")] CantTargetPreventDefeatUnits = 169,
    [pbr::OriginalName("MustTargetPreventRevealUnits")] MustTargetPreventRevealUnits = 170,
    [pbr::OriginalName("CantTargetPreventRevealUnits")] CantTargetPreventRevealUnits = 171,
    [pbr::OriginalName("MustTargetPassiveUnits")] MustTargetPassiveUnits = 172,
    [pbr::OriginalName("CantTargetPassiveUnits")] CantTargetPassiveUnits = 173,
    [pbr::OriginalName("MustTargetStunnedUnits")] MustTargetStunnedUnits = 174,
    [pbr::OriginalName("CantTargetStunnedUnits")] CantTargetStunnedUnits = 175,
    [pbr::OriginalName("MustTargetSummonedUnits")] MustTargetSummonedUnits = 176,
    [pbr::OriginalName("CantTargetSummonedUnits")] CantTargetSummonedUnits = 177,
    [pbr::OriginalName("MustTargetUser1")] MustTargetUser1 = 178,
    [pbr::OriginalName("CantTargetUser1")] CantTargetUser1 = 179,
    [pbr::OriginalName("MustTargetUnstoppableUnits")] MustTargetUnstoppableUnits = 180,
    [pbr::OriginalName("CantTargetUnstoppableUnits")] CantTargetUnstoppableUnits = 181,
    [pbr::OriginalName("MustTargetResistantUnits")] MustTargetResistantUnits = 182,
    [pbr::OriginalName("CantTargetResistantUnits")] CantTargetResistantUnits = 183,
    [pbr::OriginalName("MustTargetDazedUnits")] MustTargetDazedUnits = 184,
    [pbr::OriginalName("CantTargetDazedUnits")] CantTargetDazedUnits = 185,
    [pbr::OriginalName("CantLockdown")] CantLockdown = 186,
    [pbr::OriginalName("CantMindControl")] CantMindControl = 187,
    [pbr::OriginalName("MustTargetDestructibles")] MustTargetDestructibles = 188,
    [pbr::OriginalName("CantTargetDestructibles")] CantTargetDestructibles = 189,
    [pbr::OriginalName("MustTargetItems")] MustTargetItems = 190,
    [pbr::OriginalName("CantTargetItems")] CantTargetItems = 191,
    [pbr::OriginalName("NoCalldownAvailable")] NoCalldownAvailable = 192,
    [pbr::OriginalName("WaypointListFull")] WaypointListFull = 193,
    [pbr::OriginalName("MustTargetRace")] MustTargetRace = 194,
    [pbr::OriginalName("CantTargetRace")] CantTargetRace = 195,
    [pbr::OriginalName("MustTargetSimilarUnits")] MustTargetSimilarUnits = 196,
    [pbr::OriginalName("CantTargetSimilarUnits")] CantTargetSimilarUnits = 197,
    [pbr::OriginalName("CantFindEnoughTargets")] CantFindEnoughTargets = 198,
    [pbr::OriginalName("AlreadySpawningLarva")] AlreadySpawningLarva = 199,
    [pbr::OriginalName("CantTargetExhaustedResources")] CantTargetExhaustedResources = 200,
    [pbr::OriginalName("CantUseMinimap")] CantUseMinimap = 201,
    [pbr::OriginalName("CantUseInfoPanel")] CantUseInfoPanel = 202,
    [pbr::OriginalName("OrderQueueIsFull")] OrderQueueIsFull = 203,
    [pbr::OriginalName("CantHarvestThatResource")] CantHarvestThatResource = 204,
    [pbr::OriginalName("HarvestersNotRequired")] HarvestersNotRequired = 205,
    [pbr::OriginalName("AlreadyTargeted")] AlreadyTargeted = 206,
    [pbr::OriginalName("CantAttackWeaponsDisabled")] CantAttackWeaponsDisabled = 207,
    [pbr::OriginalName("CouldntReachTarget")] CouldntReachTarget = 208,
    [pbr::OriginalName("TargetIsOutOfRange")] TargetIsOutOfRange = 209,
    [pbr::OriginalName("TargetIsTooClose")] TargetIsTooClose = 210,
    [pbr::OriginalName("TargetIsOutOfArc")] TargetIsOutOfArc = 211,
    [pbr::OriginalName("CantFindTeleportLocation")] CantFindTeleportLocation = 212,
    [pbr::OriginalName("InvalidItemClass")] InvalidItemClass = 213,
    [pbr::OriginalName("CantFindCancelOrder")] CantFindCancelOrder = 214,
  }

  #endregion

}

#endregion Designer generated code

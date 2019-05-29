using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceManagementEventAction{
    Delete,
    Download,
    Rebuild,
    Reset,
    Upload,
 }
}

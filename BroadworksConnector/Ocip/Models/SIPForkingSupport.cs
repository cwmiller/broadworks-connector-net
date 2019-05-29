using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SIPForkingSupport{
    SingleDialog,
    SingleDialogWithUPDATE,
    MultipleDialogsWithErrorCorrection,
    MultipleDialogs,
    SingleDialogWithUPDATEIfAllowed,
 }
}

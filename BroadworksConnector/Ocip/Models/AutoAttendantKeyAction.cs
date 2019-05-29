using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AutoAttendantKeyAction{
    TransferWithPrompt,
    TransferWithoutPrompt,
    TransferToOperator,
    NameDialing,
    ExtensionDialing,
    RepeatMenu,
    Exit,
    TransferToMailbox,
    TransferToSubmenu,
    ReturntoPreviousMenu,
    PlayAnnouncement,
 }
}

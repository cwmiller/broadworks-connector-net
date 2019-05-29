using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasscodeMenuKeysModifyEntry 
{
    [XmlElement(ElementName = "finishEnteringOrReenteringPasscode", IsNullable = false)]
    public string FinishEnteringOrReenteringPasscode { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
 }
}

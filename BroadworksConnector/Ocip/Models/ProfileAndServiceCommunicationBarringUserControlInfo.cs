using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Communication Barring User Control service
    /// 
    /// profileTable has column headings: "Name", "Code", "Activated" and "Primary".
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4375""}]")]
    public class ProfileAndServiceCommunicationBarringUserControlInfo
    {

        protected bool _lockoutStatus;

        [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4375")]
        public bool LockoutStatus
        {
            get => _lockoutStatus;
            set
            {
                LockoutStatusSpecified = true;
                _lockoutStatus = value;
            }
        }

        [XmlIgnore]
        protected bool LockoutStatusSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4375")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable
        {
            get => _profileTable;
            set
            {
                ProfileTableSpecified = true;
                _profileTable = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileTableSpecified { get; set; }

    }
}

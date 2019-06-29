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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4182""}]")]
    public class ProfileAndServiceCommunicationBarringUserControlInfo
    {

        private bool _lockoutStatus;

        [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4182")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4182")]
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

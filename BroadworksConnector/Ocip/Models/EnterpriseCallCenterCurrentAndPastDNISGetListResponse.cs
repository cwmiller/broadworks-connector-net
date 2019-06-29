using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterCurrentAndPastDNISGetListRequest.
    /// <see cref="EnterpriseCallCenterCurrentAndPastDNISGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1182""}]")]
    public class EnterpriseCallCenterCurrentAndPastDNISGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _name = new List<string>();

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1182")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private List<string> _deletedName = new List<string>();

        [XmlElement(ElementName = "deletedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1182")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> DeletedName
        {
            get => _deletedName;
            set
            {
                DeletedNameSpecified = true;
                _deletedName = value;
            }
        }

        [XmlIgnore]
        protected bool DeletedNameSpecified { get; set; }

    }
}

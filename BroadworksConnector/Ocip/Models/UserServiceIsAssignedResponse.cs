using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns true if the UserService or service pack is assigned, otherwise false.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3929""}]")]
    public class UserServiceIsAssignedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isAssigned;

        [XmlElement(ElementName = "isAssigned", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3929")]
        public bool IsAssigned
        {
            get => _isAssigned;
            set
            {
                IsAssignedSpecified = true;
                _isAssigned = value;
            }
        }

        [XmlIgnore]
        protected bool IsAssignedSpecified { get; set; }

    }
}

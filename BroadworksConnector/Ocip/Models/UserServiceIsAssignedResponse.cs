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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3834""}]")]
    public class UserServiceIsAssignedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isAssigned;

        [XmlElement(ElementName = "isAssigned", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3834")]
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

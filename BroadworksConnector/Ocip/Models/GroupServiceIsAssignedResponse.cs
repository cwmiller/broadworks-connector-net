using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns true if the GroupService is assigned, otherwise false.
    /// Response to GroupServiceIsAssignedRequest
    /// <see cref="GroupServiceIsAssignedRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6861""}]")]
    public class GroupServiceIsAssignedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isAssigned;

        [XmlElement(ElementName = "isAssigned", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6861")]
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

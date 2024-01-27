using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Communication Barring Incoming Criteria.
    /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCommunicationBarringIncomingCriteriaGetRequest22
    /// <see cref="SystemCommunicationBarringIncomingCriteriaGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCommunicationBarringIncomingCriteriaGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9428""}]")]
    public class SystemCommunicationBarringIncomingCriteriaGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringIncomingCriteriaGetResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9428")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
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

    }
}

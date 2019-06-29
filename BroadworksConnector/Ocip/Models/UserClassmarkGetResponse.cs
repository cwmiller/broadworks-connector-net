using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserClassmarkGetRequest.
    /// Contains the Class Mark data
    /// <see cref="UserClassmarkGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d0e878cbc947aebb19ad489b2ffef11:188""}]")]
    public class UserClassmarkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _classmark;

        [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0d0e878cbc947aebb19ad489b2ffef11:188")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Classmark
        {
            get => _classmark;
            set
            {
                ClassmarkSpecified = true;
                _classmark = value;
            }
        }

        [XmlIgnore]
        protected bool ClassmarkSpecified { get; set; }

    }
}

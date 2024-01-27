using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Calling Party Category from system. The category cannot be deleted if it is the default or is in use by any users.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d0efd2493d3062b292fd31759011925e:73""}]")]
    public class SystemCallingPartyCategoryDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        [Group(@"d0efd2493d3062b292fd31759011925e:73")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Category
        {
            get => _category;
            set
            {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        protected bool CategorySpecified { get; set; }

    }
}

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete the entries from system Xsi application Id list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19327""}]")]
    public class SystemXsiApplicationIdDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<string> _xsiApplicationId = new List<string>();

        [XmlElement(ElementName = "xsiApplicationId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19327")]
        [MinLength(1)]
        [MaxLength(256)]
        public List<string> XsiApplicationId
        {
            get => _xsiApplicationId;
            set
            {
                XsiApplicationIdSpecified = true;
                _xsiApplicationId = value;
            }
        }

        [XmlIgnore]
        protected bool XsiApplicationIdSpecified { get; set; }

    }
}

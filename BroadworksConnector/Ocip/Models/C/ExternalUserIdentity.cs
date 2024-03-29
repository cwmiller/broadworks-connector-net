using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// External user identity id identifies pre-authenticated user/admin id performing a session-less OCI request.
    /// id can be a user/admin’s primary Id/alternate Id/external Id.
    /// organizationId identifies organization id the user/admin belongs to.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""df7d685617217d96d75d909cdade5735:22""}]")]
    public class ExternalUserIdentity
    {

        protected string _id;

        [XmlElement(ElementName = "id", IsNullable = false, Namespace = "")]
        [Group(@"df7d685617217d96d75d909cdade5735:22")]
        [MaxLength(161)]
        public string Id
        {
            get => _id;
            set
            {
                IdSpecified = true;
                _id = value;
            }
        }

        [XmlIgnore]
        protected bool IdSpecified { get; set; }

        protected string _organizationId;

        [XmlElement(ElementName = "organizationId", IsNullable = false, Namespace = "")]
        [Group(@"df7d685617217d96d75d909cdade5735:22")]
        [MaxLength(36)]
        public string OrganizationId
        {
            get => _organizationId;
            set
            {
                OrganizationIdSpecified = true;
                _organizationId = value;
            }
        }

        [XmlIgnore]
        protected bool OrganizationIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.ExternalUserIdentityRole _role;

        [XmlElement(ElementName = "role", IsNullable = false, Namespace = "")]
        [Group(@"df7d685617217d96d75d909cdade5735:22")]
        public BroadWorksConnector.Ocip.Models.C.ExternalUserIdentityRole Role
        {
            get => _role;
            set
            {
                RoleSpecified = true;
                _role = value;
            }
        }

        [XmlIgnore]
        protected bool RoleSpecified { get; set; }

    }
}

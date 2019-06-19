using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BroadWorksConnector.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void TestRequirementMissing()
        {
            Assert.Throws<FieldNotSetException>(() =>
            {
                var request = new LoginRequest14sp4();
                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestRequirementMet()
        {
            var request = new LoginRequest14sp4()
            {
                UserId = "test"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestRequirementWithArrayNotMet()
        {
            Assert.Throws<FieldNotSetException>(() =>
            {
                var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
                {
                    ServiceProviderId = "SID",
                    GroupId = "GID"
                };
                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestRequirementWithArrayMet()
        {
            var request = new GroupCommunicationBarringAuthorizationCodeAddListRequest()
            {
                ServiceProviderId = "SID",
                GroupId = "GID",
                Code = new List<CommunicationBarringAuthorizationCodeEntry>()
                {
                    new CommunicationBarringAuthorizationCodeEntry()
                    {
                        Code = "123"
                    }
                }
            };
        }

        [Fact]
        public void TestChoiceNotMet()
        {
            Assert.Throws<ChoiceNotSetException>(() =>
            {
                var request = new UserModifyRequest16Endpoint();
                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestMultipleChoiceSelections()
        {
            Assert.Throws<InvalidChoiceException>(() =>
            {
                var request = new SystemGetRegistrationContactListRequest()
                {
                    ResellerId = "reseller",
                    ServiceProviderId = "serviceProvider"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestSequenceSetInChoice()
        {
            var request = new SystemGetRegistrationContactListRequest()
            {
                GroupId = "group"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestMultipleChoiceWithSequenceSequence()
        {
            Assert.Throws<InvalidChoiceException>(() =>
            {
                var request = new SystemGetRegistrationContactListRequest()
                {
                    GroupId = "group",
                    ResellerId = "reseller"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestChoiceWithOptionalMembers()
        {
            var request = new UserAddRequest21()
            {
                ServiceProviderId = "SP",
                GroupId = "GR",
                UserId = "user@test.com",
                FirstName = "John",
                LastName = "Doe",
                CallingLineIdFirstName = "John",
                CallingLineIdLastName = "Doe"
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestChoiceWithUnsetArrays()
        {
            Assert.Throws<ChoiceNotSetException>(() =>
            {
                var request = new GroupCallCenterAddAgentListRequest()
                {
                    ServiceUserId = "test@test.com"
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestChoiceWithEmptyArrays()
        {
            var request = new GroupCallCenterAddAgentListRequest()
            {
                ServiceUserId = "test@test.com",
                AgentUserId = new List<string>() { "user@test.com" }
            };

            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestChoiceWithSetArrays()
        {
            Assert.Throws<InvalidChoiceException>(() =>
            {
                var request = new GroupCallCenterAddAgentListRequest()
                {
                    ServiceUserId = "test@test.com",
                    AgentUserId = new List<string>() { "user@test.com" },
                    AgentSkillList = new List<CallCenterSkillAgentList>()
                    {
                        new CallCenterSkillAgentList()
                        {
                            Agent = new List<string>() { "test" },
                            SkillLevel = 1
                        }
                    }
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestOptionalGroup()
        {
            var request = new SystemGetRegistrationContactListRequest();
            Assert.True(Validator.Validate(request));
        }

        [Fact]
        public void TestIncompleteObjectInArray()
        {
            Assert.Throws<FieldNotSetException>(() =>
            {
                var request = new GroupAccessDeviceGetListRequest()
                {
                    ServiceProviderId = "SP",
                    GroupId = "G",
                    SearchCriteriaDeviceMACAddress = new List<SearchCriteriaDeviceMACAddress>() {
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "000000000000"
                        }
                    }
                };

                Validator.Validate(request);
            });
        }

        [Fact]
        public void TestCompletedObjectsInArray()
        {
            var request = new GroupAccessDeviceGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "G",
                SearchCriteriaDeviceMACAddress = new List<SearchCriteriaDeviceMACAddress>() {
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "000000000000",
                            IsCaseInsensitive = false,
                            Mode = SearchMode.EqualTo
                        },
                        new SearchCriteriaDeviceMACAddress()
                        {
                            Value = "999999999999",
                            IsCaseInsensitive = true,
                            Mode = SearchMode.EqualTo
                        }
                    }
            };

        }
    }
}

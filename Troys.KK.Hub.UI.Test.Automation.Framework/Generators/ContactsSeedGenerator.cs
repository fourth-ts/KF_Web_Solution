using Bogus;
using System;

namespace Troys.KK.Hub.UI.Test.Automation.Framework.Generators
{
    public class ContactsSeedGenerator
    {
        private readonly Faker<Contact> faker;

        public ContactsSeedGenerator()
        {
            this.faker = new Faker<Contact>()
                .RuleFor(f => f.Id, f => default(Guid)
                //.RuleFor(f => f.Descn, f => f.Lorem.Word())
                //.RuleFor(f => f.Address1, f => f.Address.StreetName())
                //.RuleFor(f => f.Postcode, f => f.Address.ZipCode())
                //.RuleFor(f => f.IsStock, f => false)
                //.RuleFor(f => f.DateCreated, f => DateTime.Today)
                //.RuleFor(f => f.LastModified, f => DateTime.Today)
                //.RuleFor(f => f.EposformatId, f => 0)
                //.RuleFor(f => f.StockMoveRefStart, f => 1)
                //.RuleFor(f => f.SiteCodePrefix, f => f.Random.Number(1, 30).ToString())
                //.RuleFor(f => f.RecordStatus, f => false)

                //.RuleFor(f => f.LocationGuid, f => default(Guid)



                );



            //,[Title]
            //,[FirstName]
            //,[LastName]
            //,[FormalSalutation]
            //,[SemiformalSalutation]
            //,[InformalSalutation]
            //,[PersonalSalutation]
            //,[EnvelopeSalutation]
            //,[DefaultSalutationId]
            //,[NationalityId]
            //,[IsPodDoNotCall]
            //,[IsSuperRichAdvisor]
            //,[SuperRichProfile]
            //,[Source]
            //,[PersonalWealthId]
            //,[ProfessionId]
            //,[ProfessionText]
            //,[AgeBandId]
            //,[ApproxBirthDate]
            //,[TwitterUrl]
            //,[LinkedInUrl]
            //,[WebsiteUrl]
            //,[CddWarningFlag]
            //,[MaskedClaimsId]
            //,[VisibleClaimsId]
            //,[Version]
            //,[Deleted]
            //,[AlternativeTitle]
            //,[AlternativeFirstName]
            //,[AlternativeLastName]
            //,[DataHugOnly]
            //,[HighestDataHugRank]
            //,[LatestLastInteractionDate]
            //,[LatestLastInteractionById]
            //,[IsDeceased]
            //,[IsRetired]
            //,[FairProcessingNoticeId]
            //,[QubeSynchronized]
            //,[QubeErrorOccurred]
            //,[DomicileCountryId]
            //,[DomicileRegionId]
            //,[SourceOfIncomeId]
            //,[CreatedByUserId]
            //,[LastModifiedByUserId]
            //,[CreationTime]
            //,[LastWriteTime]
            //,[UserId]

        }



        public Contact Generate()
        {
            return this.faker.Generate();
        }
    }
}

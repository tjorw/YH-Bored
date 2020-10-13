
using Bored.Services.Times;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bored.Mocks.Times
{
    public class TimesApiServiceMock : ITimesApiService
    {
        public async Task<TimesArticleResultDTO> GetArticles()
        {
            await Task.Run(() => { });
            try
            {
                return JsonConvert.DeserializeObject<TimesArticleResultDTO>(sampleData);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            } 
        }

        public Task<string> SomeOtherMethod1()
        {
            throw new NotImplementedException();
        }

        public Task<string> SomeOtherMethod2()
        {
            throw new NotImplementedException();
        }

        private string sampleData => @"
{
 'status': 'OK',
 'copyright': 'Copyright (c) 2020 The New York Times Company. All Rights Reserved.',
 'num_results': 20,
 'results': [
 {
 'uri': 'nyt://article/d54ddf9a-e444-5f7d-a6ed-ca0ec72d8628',
 'url': 'https://www.nytimes.com/2020/10/12/us/politics/california-gop-drop-boxes.html',
 'id': 100000007391724,
 'asset_id': 100000007391724,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 06:02:35',
 'section': 'U.S.',
 'subsection': 'Politics',
 'nytdsection': 'u.s.',
 'adx_keywords': 'Absentee Voting;Presidential Election of 2020;United States Politics and
Government;Trump, Donald J;Republican Party;California',
 'column': null,
 'byline': 'By Glenn Thrush and Jennifer Medina',
 'type': 'Article',
 'title': 'California Republican Party Admits It Placed Misleading Ballot Boxes Around State',
 'abstract': 'Government officials say the receptacles are illegal and could lead to voter fraud,
but the party says it will continue the practice.',
 'des_facet': [
 'Absentee Voting',
 'Presidential Election of 2020',
 'United States Politics and Government'
 ],
 'org_facet': [
 'Republican Party'
 ],
 'per_facet': [
 'Trump, Donald J'
 ],
 'geo_facet': [
 'California'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'State officials in California have ordered an investigation into more than 50
deceptively labeled “official” drop boxes.',
 'copyright': 'Mike Blake/Reuters',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/politics/12California/
merlin_171569139_3b8452c8-285b-4ab0-b3fc-36be28777fe5-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/politics/12California/
merlin_171569139_3b8452c8-285b-4ab0-b3fc-36be28777fe5-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/politics/12California/
merlin_171569139_3b8452c8-285b-4ab0-b3fc-36be28777fe5-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/17cd0bb5-af87-5fda-ab45-93655efc9551',
 'url': 'https://www.nytimes.com/2020/10/12/health/covid-vaccines.html',
 'id': 100000007376486,
 'asset_id': 100000007376486,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-12 23:11:40',
 'section': 'Health',
 'subsection': '',
 'nytdsection': 'health',
 'adx_keywords': 'Clinical Trials;Vaccination and Immunization;Coronavirus Risks and Safety
Concerns;Public-Private Sector Cooperation;Coronavirus (2019-nCoV);Placebos;Research;United
States Politics and Government;your-feed-healthcare;your-feed-science;Food and Drug
Administration;National Institutes of Health',
 'column': null,
 'byline': 'By Carl Zimmer',
 'type': 'Article',
 'title': 'First, a Vaccine Approval. Then ‘Chaos and Confusion.’',
 'abstract': 'Come spring, Americans may have their choice of several so-so coronavirus
vaccines — with no way of knowing which one is best.',
 'des_facet': [
 'Clinical Trials',
 'Vaccination and Immunization',
 'Coronavirus Risks and Safety Concerns',
 'Public-Private Sector Cooperation',
 'Coronavirus (2019-nCoV)',
 'Placebos',
 'Research',
 'United States Politics and Government',
 'your-feed-healthcare',
 'your-feed-science'
 ],
 'org_facet': [
 'Food and Drug Administration',
 'National Institutes of Health'
 ],
 'per_facet': [],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': '',
 'copyright': 'Emiliano Ponzi',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/13/science/12SCI-VIRUSVACCINE1/12SCI-VIRUS-VACCINE1-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/13/science/12SCI-VIRUSVACCINE1/12SCI-VIRUS-VACCINE1-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/13/science/12SCI-VIRUSVACCINE1/12SCI-VIRUS-VACCINE1-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://interactive/cba553d7-2ebc-597f-bd74-de3f617296e0',
 'url': 'https://www.nytimes.com/interactive/2014/upshot/dialect-quiz-map.html',
 'id': 100000002615736,
 'asset_id': 100000002615736,
 'source': 'New York Times',
 'published_date': '2013-12-21',
 'updated': '2020-10-06 18:12:03',
 'section': 'The Upshot',
 'subsection': '',
 'nytdsection': 'the upshot',
 'adx_keywords': 'Language and Languages;English Language',
 'column': null,
 'byline': 'By Josh Katz and Wilson Andrews',
 'type': 'Interactive',
 'title': 'How Y’all, Youse and You Guys Talk',
 'abstract': 'What does the way you speak say about where you’re from? Answer all the
questions below to see your personal dialect map.',
 'des_facet': [
 'Language and Languages',
 'English Language'
 ],
 'org_facet': [],
 'per_facet': [],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': '',
 'caption': '',
 'copyright': '',
 'approved_for_syndication': 0,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2016/11/24/us/map-dialect/map-dialectthumbStandard.png',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2016/11/24/us/map-dialect/map-dialectmediumThreeByTwo210.png',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2016/11/24/us/map-dialect/map-dialectmediumThreeByTwo440.png',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/cf3f5394-3e57-5dcb-880d-678cca8fe54f',
 'url': 'https://www.nytimes.com/2020/10/12/upshot/polls-wisconsin-michigan-election.html',
 'id': 100000007390634,
 'asset_id': 100000007390634,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 00:25:09',
 'section': 'The Upshot',
 'subsection': '',
 'nytdsection': 'the upshot',
 'adx_keywords': 'Presidential Election of 2020;Polls and Public Opinion;Biden, Joseph R
Jr;Trump, Donald J;James, John (1981- );Peters, Gary;Michigan;Wisconsin',
 'column': null,
 'byline': 'By Nate Cohn',
 'type': 'Article',
 'title': 'Trump Defectors Help Biden Build Leads in Wisconsin and Michigan',
 'abstract': 'New polls show Biden is gaining in the Northern battlegrounds among white
voters.',
 'des_facet': [
 'Presidential Election of 2020',
 'Polls and Public Opinion'
 ],
 'org_facet': [],
 'per_facet': [
 'Biden, Joseph R Jr',
 'Trump, Donald J',
 'James, John (1981- )',
 'Peters, Gary'
 ],
 'geo_facet': [
 'Michigan',
 'Wisconsin'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': '',
 'copyright': '',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/-promo-1602515847190/-
promo-1602515847190-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/-promo-1602515847190/-
promo-1602515847190-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/-promo-1602515847190/-
promo-1602515847190-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/4cc4804f-f288-5c49-b776-0a2a00683b2c',
 'url': 'https://www.nytimes.com/2020/10/11/health/covid-survivors.html',
 'id': 100000007383774,
 'asset_id': 100000007383774,
 'source': 'New York Times',
 'published_date': '2020-10-11',
 'updated': '2020-10-12 09:49:23',
 'section': 'Health',
 'subsection': '',
 'nytdsection': 'health',
 'adx_keywords': 'Coronavirus (2019-nCoV);Coronavirus Risks and Safety
Concerns;Memory;Chronic Condition (Health);Brain;your-feed-science',
 'column': null,
 'byline': 'By Pam Belluck',
 'type': 'Article',
 'title': '‘I Feel Like I Have Dementia’: Brain Fog Plagues Covid Survivors',
 'abstract': 'The condition is affecting thousands of patients, impeding their ability to work and
function in daily life.',
 'des_facet': [
 'Coronavirus (2019-nCoV)',
 'Coronavirus Risks and Safety Concerns',
 'Memory',
 'Chronic Condition (Health)',
 'Brain',
 'your-feed-science'
 ],
 'org_facet': [],
 'per_facet': [],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'Michael Reagan at home in New York City. Lingering cognitive and neurological
symptoms have forced him to take a leave from his job.',
 'copyright': 'Hiroko Masuike/The New York Times',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/10/science/00VIRUSBRAINFOG01/00VIRUS-BRAINFOG01-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/10/science/00VIRUSBRAINFOG01/00VIRUS-BRAINFOG01-mediumThreeByTwo210-v2.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/10/science/00VIRUSBRAINFOG01/00VIRUS-BRAINFOG01-mediumThreeByTwo440-v2.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/8dd509a1-f7ed-5a44-8076-64d2d8b9c84f',
 'url': 'https://www.nytimes.com/2020/10/11/business/media/new-york-times-rukminicallimachi-caliphate.html',
 'id': 100000007372866,
 'asset_id': 100000007372866,
 'source': 'New York Times',
 'published_date': '2020-10-11',
 'updated': '2020-10-12 19:43:23',
 'section': 'Business',
 'subsection': 'Media',
 'nytdsection': 'business',
 'adx_keywords': 'Terrorism;News and News Media;Podcasts;Hoaxes and Pranks;Callimachi,
Rukmini Maria (1973- );Chaudhry, Shehroze;New York Times;Islamic State in Iraq and Syria
(ISIS);Syria',
 'column': null,
 'byline': 'By Ben Smith',
 'type': 'Article',
 'title': 'An Arrest in Canada Casts a Shadow on a New York Times Star, and The Times',
 'abstract': 'A top editor is now reviewing Rukmini Callimachi’s reporting on terrorism, which
turned distant conflicts into accessible stories but drew criticism from colleagues.',
 'des_facet': [
 'Terrorism',
 'News and News Media',
 'Podcasts',
 'Hoaxes and Pranks'
 ],
 'org_facet': [
 'New York Times',
 'Islamic State in Iraq and Syria (ISIS)'
 ],
 'per_facet': [
 'Callimachi, Rukmini Maria (1973- )',
 'Chaudhry, Shehroze'
 ],
 'geo_facet': [
 'Syria'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'A freelancer, Derek Henry Flood, visited this market in Manbij, Syria, at the
request of a Times reporter. He left town when he got a warning of danger.',
 'copyright': 'Derek Henry Flood',
 'approved_for_syndication': 0,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/business/11bensmith-pic/
11bensmith-pic-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/business/11bensmith-pic/
11bensmith-pic-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/business/11bensmith-pic/
11bensmith-pic-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/b02d8046-1a4c-5436-882b-679cb60b4d9d',
 'url': 'https://www.nytimes.com/2020/10/12/us/politics/barrett-confirmation-hearingsupreme-court.html',
 'id': 100000007391218,
 'asset_id': 100000007391218,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 07:16:26',
 'section': 'U.S.',
 'subsection': 'Politics',
 'nytdsection': 'u.s.',
 'adx_keywords': 'Appointments and Executive Changes;United States Politics and
Government;Coronavirus (2019-nCoV);Conservatism (US Politics);Patient Protection and
Affordable Care Act (2010);Barrett, Amy Coney;Graham, Lindsey;Trump, Donald J;Supreme Court
(US);Senate Committee on the Judiciary;Senate;Republican Party;Democratic Party',
 'column': null,
 'byline': 'By Nicholas Fandos',
 'type': 'Article',
 'title': 'Two Parties Offer Dueling Views of Barrett as Confirmation Fight Begins',
 'abstract': 'On the first day of the election-season confirmation hearings, Democrats
portrayed Judge Amy Coney Barrett as a threat to Americans’ health care coverage as
Republicans charged anti-Catholic bias.',
 'des_facet': [
 'Appointments and Executive Changes',
 'United States Politics and Government',
 'Coronavirus (2019-nCoV)',
 'Conservatism (US Politics)',
 'Patient Protection and Affordable Care Act (2010)'
 ],
 'org_facet': [
 'Supreme Court (US)',
 'Senate Committee on the Judiciary',
 'Senate',
 'Republican Party',
 'Democratic Party'
 ],
 'per_facet': [
 'Barrett, Amy Coney',
 'Graham, Lindsey',
 'Trump, Donald J'
 ],
 'geo_facet': [],
 'media': [],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/a3ed92e8-4613-55e3-9a7a-88dc6c9542dc',
 'url': 'https://www.nytimes.com/2020/10/12/climate/home-sales-florida.html',
 'id': 100000007378820,
 'asset_id': 100000007378820,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 00:37:36',
 'section': 'Climate',
 'subsection': '',
 'nytdsection': 'climate',
 'adx_keywords': 'Global Warming;Environment;Greenhouse Gas Emissions;Real Estate and
Housing (Residential);Florida;Florida Keys;Miami-Dade County (Fla)',
 'column': null,
 'byline': 'By Christopher Flavelle',
 'type': 'Article',
 'title': 'Florida Sees Signals of a Climate-Driven Housing Crisis',
 'abstract': 'Home sales in areas most vulnerable to sea-level rise began falling around 2013,
researchers found. Now, prices are following a similar downward path.',
 'des_facet': [
 'Global Warming',
 'Environment',
 'Greenhouse Gas Emissions',
 'Real Estate and Housing (Residential)'
 ],
 'org_facet': [],
 'per_facet': [],
 'geo_facet': [
 'Florida',
 'Florida Keys',
 'Miami-Dade County (Fla)'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'In places like Bal Harbour, Fla., climate worries have reduced demand for highrisk coastal real estate, researchers say.',
 'copyright': 'Rose Marie Cromwell for The New York Times',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/13/science/12CLI-FLORIDA01/12CLIFLORIDA01-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/13/science/12CLI-FLORIDA01/
merlin_178301409_6afa210c-ef5c-4334-9edb-874d3b3fd00f-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/13/science/12CLI-FLORIDA01/
merlin_178301409_6afa210c-ef5c-4334-9edb-874d3b3fd00f-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/474faaf2-de31-57b6-99c5-6e291b095ddf',
 'url': 'https://www.nytimes.com/2020/10/12/health/coronavirus-pandemic-vaccineoptimism.html',
 'id': 100000007350913,
 'asset_id': 100000007350913,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-12 23:07:20',
 'section': 'Health',
 'subsection': '',
 'nytdsection': 'health',
 'adx_keywords': 'Clinical Trials;Dexamethasone (Drug);Disease Rates;Coronavirus (2019-
nCoV);Vaccination and Immunization;Deaths (Fatalities);Drugs (Pharmaceuticals)',
 'column': null,
 'byline': 'By Donald G. McNeil Jr.',
 'type': 'Article',
 'title': 'A Dose of Optimism, as the Pandemic Rages On',
 'abstract': 'The months ahead will be difficult. But the medical cavalry is coming, and the rest
of us know what we need to do.',
 'des_facet': [
 'Clinical Trials',
 'Dexamethasone (Drug)',
 'Disease Rates',
 'Coronavirus (2019-nCoV)',
 'Vaccination and Immunization',
 'Deaths (Fatalities)',
 'Drugs (Pharmaceuticals)'
 ],
 'org_facet': [],
 'per_facet': [],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': '',
 'copyright': 'Emiliano Ponzi',
 'approved_for_syndication': 0,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/science/12SCI-OPTIMISM-promo/
12SCI-OPTIMISM-promo-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/science/12SCI-OPTIMISM-promo/
12SCI-OPTIMISM-promo-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/science/12SCI-OPTIMISM-promo/
12SCI-OPTIMISM-promo-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/1cec4370-5044-5458-87bb-bc0642019a66',
 'url': 'https://www.nytimes.com/2020/10/12/us/politics/gisele-fetterman-pennsylvania.html',
 'id': 100000007390834,
 'asset_id': 100000007390834,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 06:00:33',
 'section': 'U.S.',
 'subsection': 'Politics',
 'nytdsection': 'u.s.',
 'adx_keywords': 'Discrimination;United States Politics and Government;Politics and
Government;Fetterman, John (1969- );Fetterman, Gisele Barreto;Braddock (Pa);Pennsylvania',
 'column': null,
 'byline': 'By Johnny Diaz',
 'type': 'Article',
 'title': 'Wife of Pennsylvania’s Lieutenant Governor Is Target of Racial Slur',
 'abstract': 'Gisele Barreto Fetterman, the wife of Lt. Gov. John Fetterman, said a woman
taunted her at a grocery store. Ms. Fetterman shared video of the confrontation on Twitter.',
 'des_facet': [
 'Discrimination',
 'United States Politics and Government',
 'Politics and Government'
 ],
 'org_facet': [],
 'per_facet': [
 'Fetterman, John (1969- )',
 'Fetterman, Gisele Barreto'
 ],
 'geo_facet': [
 'Braddock (Pa)',
 'Pennsylvania'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'Gisele Barreto Fetterman, the second lady of Pennsylvania, appeared earlier this
year in Erie, Pa.',
 'copyright': 'Greg Wohlford/Erie Times-News, via Associated Press',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/multimedia/12xp-fetterman/12xpfetterman-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/multimedia/12xp-fetterman/12xpfetterman-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/multimedia/12xp-fetterman/12xpfetterman-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/cd22a467-6f36-511e-9815-8de2775ed41a',
 'url': 'https://www.nytimes.com/2020/10/12/business/leon-black-jeffrey-epstein.html',
 'id': 100000007379713,
 'asset_id': 100000007379713,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 03:45:12',
 'section': 'Business',
 'subsection': '',
 'nytdsection': 'business',
 'adx_keywords': 'Human Trafficking;Prostitution;High Net Worth Individuals;Sex
Crimes;Black, Leon D;Epstein, Jeffrey E (1953- );Apollo Global Management',
 'column': null,
 'byline': 'By Matthew Goldstein, Steve Eder and David Enrich',
 'type': 'Article',
 'title': 'The Billionaire Who Stood by Jeffrey Epstein',
 'abstract': 'Leon Black, whose $9 billion fortune could buy the best counsel in the world, paid
at least $50 million to Mr. Epstein for advice and services after most others had deserted him.',
 'des_facet': [
 'Human Trafficking',
 'Prostitution',
 'High Net Worth Individuals',
 'Sex Crimes'
 ],
 'org_facet': [
 'Apollo Global Management'
 ],
 'per_facet': [
 'Black, Leon D',
 'Epstein, Jeffrey E (1953- )'
 ],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'Jeffrey Epstein and Mr. Black with the sugar-cane magnate José Fanjul at a
movie screening in 2005. Mr. Epstein and Mr. Black knew each other for decades.',
 'copyright': 'Joe Schildhorn/Patrick McMullan, via Getty Images',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/08/business/00leon4/00leon4-
thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/08/business/00leon4/00leon4-
mediumThreeByTwo210-v2.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/08/business/00leon4/00leon4-
mediumThreeByTwo440-v2.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/305d9def-2dbc-5045-85b7-d581e12a1fea',
 'url': 'https://www.nytimes.com/2020/10/12/business/nobel-economics-paul-milgrom-robertwilson.html',
 'id': 100000007382362,
 'asset_id': 100000007382362,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 00:37:46',
 'section': 'Business',
 'subsection': '',
 'nytdsection': 'business',
 'adx_keywords': 'Nobel Prizes;Economics (Theory and Philosophy);Auctions;Radio
Spectrum;Milgrom, Paul Robert;Wilson, Robert B (1937- )',
 'column': null,
 'byline': 'By Jeanna Smialek',
 'type': 'Article',
 'title': 'U.S. Auction Theorists Win the 2020 Nobel in Economics',
 'abstract': 'Paul Milgrom and Robert Wilson were honored for work that has pushed auctions
into new and useful territory.',
 'des_facet': [
 'Nobel Prizes',
 'Economics (Theory and Philosophy)',
 'Auctions',
 'Radio Spectrum'
 ],
 'org_facet': [],
 'per_facet': [
 'Milgrom, Paul Robert',
 'Wilson, Robert B (1937- )'
 ],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'Paul R. Milgrom and Robert B. Wilson were awarded the Nobel in economic
science on Monday for improvements to auction theory and inventions of auction formats.',
 'copyright': 'Anders Wiklund/TT News Agency, via Associated Press',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/business/12nobel-econ-sub/12nobelecon-sub-thumbStandard-v2.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/business/12nobel-econ-sub/12nobelecon-sub-mediumThreeByTwo210-v2.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/business/12nobel-econ-sub/12nobelecon-sub-mediumThreeByTwo440-v2.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/efd88313-6c28-58d8-9608-94af430623ac',
 'url': 'https://www.nytimes.com/2020/10/10/opinion/sunday/trump-electionauthoritarianism.html',
 'id': 100000007387703,
 'asset_id': 100000007387703,
 'source': 'New York Times',
 'published_date': '2020-10-10',
 'updated': '2020-10-12 19:53:05',
 'section': 'Opinion',
 'subsection': 'Sunday Review',
 'nytdsection': 'opinion',
 'adx_keywords': 'Presidential Election of 2020;United States Politics and
Government;Liberalism (US Politics);Trump, Donald J',
 'column': null,
 'byline': 'By Ross Douthat',
 'type': 'Article',
 'title': 'There Will Be No Trump Coup',
 'abstract': 'A final pre-election case for understanding the president as a noisy weakling, not
a budding autocrat.',
 'des_facet': [
 'Presidential Election of 2020',
 'United States Politics and Government',
 'Liberalism (US Politics)'
 ],
 'org_facet': [],
 'per_facet': [
 'Trump, Donald J'
 ],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': '',
 'copyright': 'Oliver Contreras for The New York Times',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/opinion/10Douthat/10DouthatthumbStandard-v2.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/opinion/10Douthat/10DouthatmediumThreeByTwo210-v2.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/opinion/10Douthat/10DouthatmediumThreeByTwo440-v2.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/1c5ef6b8-87f7-53b1-b17c-4bdbec9946c3',
 'url': 'https://www.nytimes.com/2020/10/11/us/politics/amy-coney-barrett-life-careerfamily.html',
 'id': 100000007382399,
 'asset_id': 100000007382399,
 'source': 'New York Times',
 'published_date': '2020-10-11',
 'updated': '2020-10-12 18:15:59',
 'section': 'U.S.',
 'subsection': 'Politics',
 'nytdsection': 'u.s.',
 'adx_keywords': 'Appointments and Executive Changes;United States Politics and
Government;Conservatism (US Politics);Law and Legislation;Appeals Courts (US);Christians and
Christianity;Barrett, Amy Coney;McGahn, Donald F II;Trump, Donald J;Scalia, Antonin;Supreme
Court (US);Roman Catholic Church;University of Notre Dame',
 'column': null,
 'byline': 'By Elizabeth Dias, Rebecca R. Ruiz and Sharon LaFraniere',
 'type': 'Article',
 'title': 'Rooted in Faith, Amy Coney Barrett Represents a New Conservatism',
 'abstract': 'As Judge Barrett’s confirmation hearings are set to begin Monday, her
background and résumé are a stark departure from those of more traditional nominees to the
Supreme Court.',
 'des_facet': [
 'Appointments and Executive Changes',
 'United States Politics and Government',
 'Conservatism (US Politics)',
 'Law and Legislation',
 'Appeals Courts (US)',
 'Christians and Christianity'
 ],
 'org_facet': [
 'Supreme Court (US)',
 'Roman Catholic Church',
 'University of Notre Dame'
 ],
 'per_facet': [
 'Barrett, Amy Coney',
 'McGahn, Donald F II',
 'Trump, Donald J',
 'Scalia, Antonin'
 ],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'At just 48, Judge Amy Coney Barrett brings with her the promise of shaping
American law for a generation.',
 'copyright': 'Andrea Morales for The New York Times',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/us/politics/11dc-barrett-1/
merlin_177605616_8a892ae3-fa57-4a7a-89ca-d822e9491e8c-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/us/politics/11dc-barrett-1/11dcbarrett-1-mediumThreeByTwo210-v3.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/us/politics/11dc-barrett-1/11dcbarrett-1-mediumThreeByTwo440-v3.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/33e661ec-1d4d-5f1c-b3bc-623af718eaa0',
 'url': 'https://www.nytimes.com/2020/10/12/nyregion/nyc-crime-subway.html',
 'id': 100000007378269,
 'asset_id': 100000007378269,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-12 18:47:55',
 'section': 'New York',
 'subsection': '',
 'nytdsection': 'new york',
 'adx_keywords': 'Subways;Robberies and Thefts;Murders, Attempted Murders and
Homicides;Vandalism;Sex Crimes;Coronavirus (2019-nCoV);Metropolitan Transportation
Authority;New York City Transit Authority;New York City',
 'column': null,
 'byline': 'By Christina Goldbaum',
 'type': 'Article',
 'title': 'In Emptier Subways, Violent Crime Is Rising',
 'abstract': 'Reports of homicides, rapes and burglaries are posing another challenge to
regaining the confidence of passengers during the pandemic.',
 'des_facet': [
 'Subways',
 'Robberies and Thefts',
 'Murders, Attempted Murders and Homicides',
 'Vandalism',
 'Sex Crimes',
 'Coronavirus (2019-nCoV)'
 ],
 'org_facet': [
 'Metropolitan Transportation Authority',
 'New York City Transit Authority'
 ],
 'per_facet': [],
 'geo_facet': [
 'New York City'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'When the coronavirus shuttered much of New York in the spring, subway
ridership plunged.',
 'copyright': 'Gregg Vigliotti for The New York Times',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/08/nyregion/
00subwaycrime2/00subwaycrime2-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/08/nyregion/
00subwaycrime2/00subwaycrime2-mediumThreeByTwo210-v2.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/08/nyregion/
00subwaycrime2/00subwaycrime2-mediumThreeByTwo440-v2.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/86f59265-1c04-5262-b242-7d868e478f87',
 'url': 'https://www.nytimes.com/2020/10/12/us/politics/biden-trump-pennsylvania.html',
 'id': 100000007388993,
 'asset_id': 100000007388993,
 'source': 'New York Times',
 'published_date': '2020-10-12',
 'updated': '2020-10-13 00:15:22',
 'section': 'U.S.',
 'subsection': 'Politics',
 'nytdsection': 'u.s.',
 'adx_keywords': 'Presidential Election of 2020;Presidential Election of 2016;Polls and Public
Opinion;United States Politics and Government;White House Coronavirus Outbreak (2020);Voting 
and Voters;Rural Areas;Biden, Joseph R Jr;Clinton, Hillary Rodham;Trump, Donald J;Democratic
Party;Republican Party;Latrobe (Pa);Pennsylvania',
 'column': null,
 'byline': 'By Katie Glueck',
 'type': 'Article',
 'title': 'Democrats in Trump Country: They’re Not Shy Anymore About Liking Biden',
 'abstract': 'As the campaign enters the final stretch, some Democrats in Trump country are
less hesitant than before to express their preference. The surge in enthusiasm reflects an urgency
for Democrats desperate to oust the president.',
 'des_facet': [
 'Presidential Election of 2020',
 'Presidential Election of 2016',
 'Polls and Public Opinion',
 'United States Politics and Government',
 'White House Coronavirus Outbreak (2020)',
 'Voting and Voters',
 'Rural Areas'
 ],
 'org_facet': [
 'Democratic Party',
 'Republican Party'
 ],
 'per_facet': [
 'Biden, Joseph R Jr',
 'Clinton, Hillary Rodham',
 'Trump, Donald J'
 ],
 'geo_facet': [
 'Latrobe (Pa)',
 'Pennsylvania'
 ],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'Biden supporters picked up signs from the Westmoreland County Democratic
office in Greensburg, Pa., on Saturday. Joseph R. Biden Jr. is trying to cut into President Trump’s
overwhelming margins of victory in rural areas.',
 'copyright': 'Nate Smallwood for The New York Times',
 'approved_for_syndication': 1,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/politics/
12shybidenvoter1/12shybidenvoter1-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/politics/
12shybidenvoter1/12shybidenvoter1-mediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/12/us/politics/
12shybidenvoter1/12shybidenvoter1-mediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 },
 {
 'uri': 'nyt://article/7b89549b-1a3f-5c61-8a49-611a217aaae3',
 'url': 'https://www.nytimes.com/2020/10/11/arts/television/snl-fly-pence-jim-carrey.html',
 'id': 100000007389401,
 'asset_id': 100000007389401,
 'source': 'New York Times',
 'published_date': '2020-10-11',
 'updated': '2020-10-12 19:37:14',
 'section': 'Arts',
 'subsection': 'Television',
 'nytdsection': 'arts',
 'adx_keywords': 'Television;Carrey, Jim;Pence, Mike;Burr, Bill;White, Jack',
 'column': null,
 'byline': 'By Dave Itzkoff',
 'type': 'Article',
 'title': '‘S.N.L.’ Has a Theory About the Fly That Landed on Mike Pence’s Head',
 'abstract': '“Saturday Night Live” satirized Wednesday’s vice-presidential debate in an
episode of comedy monologues guaranteed to press everyone’s buttons.',
 'des_facet': [
 'Television'
 ],
 'org_facet': [],
 'per_facet': [
 'Carrey, Jim',
 'Pence, Mike',
 'Burr, Bill',
 'White, Jack'
 ],
 'geo_facet': [],
 'media': [
 {
 'type': 'image',
 'subtype': 'photo',
 'caption': 'Jim Carrey guest starred as former Vice President Joseph R. Biden Jr., whom
“S.N.L.” transformed into the fly that landed on Vice President Mike Pence’s head during
Wednesday’s debate.&nbsp;',
 'copyright': 'Will Heath/NBC',
 'approved_for_syndication': 0,
 'media-metadata': [
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/arts/11snl/11snl-thumbStandard.jpg',
 'format': 'Standard Thumbnail',
 'height': 75,
 'width': 75
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/arts/11snl/11snlmediumThreeByTwo210.jpg',
 'format': 'mediumThreeByTwo210',
 'height': 140,
 'width': 210
 },
 {
 'url': 'https://static01.nyt.com/images/2020/10/11/arts/11snl/11snlmediumThreeByTwo440.jpg',
 'format': 'mediumThreeByTwo440',
 'height': 293,
 'width': 440
 }
 ]
 }
 ],
 'eta_id': 0
 } ]
}";
    }
}

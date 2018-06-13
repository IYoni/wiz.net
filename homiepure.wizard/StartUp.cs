
using homiepure.wizard.UserControls;

namespace homiepure.wizard
{
    public class StartUp
    {
        // Defines the wizard road map
        public static WizardMap WizInit()
        {
            #region // Initialize some global/shared resources

            // will be used to show task progress and status
            //WizardMap.FrmUcControlLoader.panelLoader.Controls.Add(WizardMap.UcTaskProgress);
            // turn visibility on
            //WizardMap.FrmUcControlLoader.panelLoader.Controls[WizardMap.UcTaskProgress.Name].Visible = true;

            // 
            // TODO: Default vlues come from config file,
            //
            //WizardMap.SourceDbProperties = new DbConnectionProperties
            //{
            //    DataSource = @".\MsSql12",
            //    InitialCatalog = "sampledb1",
            //    IsIntegratedSecurity = true,
            //    UserId = string.Empty,
            //    Password = string.Empty
            //};

            //WizardMap.DestinationDbProperties = new DbConnectionProperties
            //{
            //    DataSource = @".\MsSql12",
            //    InitialCatalog = "sample_prc",
            //    IsIntegratedSecurity = true,
            //    UserId = string.Empty,
            //    Password = string.Empty,
            //};

            //DalFactory.DalFactory.DalFactory factory = new DbDalFactory();
            //var dal = factory.GetDataAccessLayer(DataProviderType.Sql, WizardMap.SourceDbProperties);

            // Source ConnectionString
            //WizardMap.SourceDbConnectionString = dal.ConnectionString;

            //factory = new DbDalFactory();
            //dal = factory.GetDataAccessLayer(DataProviderType.Sql, WizardMap.DestinationDbProperties);

            // Destination ConnectionString
            //WizardMap.DestinationConnectionString = dal.ConnectionString;

            #endregion

            // Start preparing wizard pages
            // The following code region creates wizard pages and put them in their respective order
            #region Wizard Pages

            // WizardMap will contain all wizard pages with their respective index order 
            WizardMap wizardMap = new WizardMap();
            {
                // Create Page
                UcFirstPage ucFirstPage = new UcFirstPage();
                WizardPage wizardPage = new WizardPage
                {
                    Name = ucFirstPage.Name,
                    Control = ucFirstPage,
                    Index = 1, // Page Index (Number)
                    TaskDescription = string.Empty,
                    HasAction = false,
                    DoTask = ucFirstPage.DoTaskHandler,
                    DoTaskOnNextLeaveEventHandler = ucFirstPage.DoTaskOnNextLeaveEventHandler,
                    DoTaskOnBackLeaveEventHandler = ucFirstPage.DoTaskOnBackLeaveEventHandler
                };

                // Important
                wizardMap.CurrentPage = wizardPage;
                WizardMap.PageNumber = wizardMap.CurrentPage.Index;

                WizardMap.WizardPages.Add(wizardPage);
            }

            {
                UcPageExtendable ucSecondPage = new UcPageExtendable();
                ucSecondPage.Name = "SecondPage"; // Todo: configure this from the physical page 
                WizardPage wizardPage = new WizardPage
                {
                    Name = ucSecondPage.Name,
                    Control = ucSecondPage,
                    Index = 2, // Page Index (Number)
                    TaskDescription = @"<Action title, tells what to do>.",
                    HasAction = false,
                    DoTask = ucSecondPage.DoTaskHandler,
                    DoTaskOnNextLeaveEventHandler = ucSecondPage.DoTaskOnNextLeaveEventHandler,
                    DoTaskOnBackLeaveEventHandler = ucSecondPage.DoTaskOnBackLeaveEventHandler,
                    DoTaskOnLoadEventHandler = ucSecondPage.DoTaskOnLoadEventHandler,
                    DoTaskOnChangeEventHandler = ucSecondPage.DoTaskOnChangeEventHandler,
                    HasChanges = ucSecondPage.HasChanges
                };

                // Important
                wizardMap.NextPage = wizardPage;
                WizardMap.WizardPages.Add(wizardPage);
            }

            {
                UcPageExtendable ucThirdPage = new UcPageExtendable();
                ucThirdPage.Name = "ThirdPage"; // Todo: configure this from the physical page 
                WizardPage wizardPage = new WizardPage
                {
                    Name = ucThirdPage.Name,
                    Control = ucThirdPage,
                    Index = 3, // Page Index (Number)
                    TaskDescription = @"<Todos as task list, configurable via checkbox radio buttons to be tasked>.",
                    HasAction = false,
                    DoTask = ucThirdPage.DoTaskHandler,
                    DoTaskOnNextLeaveEventHandler = ucThirdPage.DoTaskOnNextLeaveEventHandler,
                    DoTaskOnBackLeaveEventHandler = ucThirdPage.DoTaskOnBackLeaveEventHandler,
                    DoTaskOnLoadEventHandler = ucThirdPage.DoTaskOnLoadEventHandler,
                    DoTaskOnChangeEventHandler = ucThirdPage.DoTaskOnChangeEventHandler,
                    HasChanges = ucThirdPage.HasChanges
                };

                WizardMap.WizardPages.Add(wizardPage);
            }

            {
                UcPageExtendable ucFourthPage = new UcPageExtendable();
                ucFourthPage.Name = "FourthPage"; // Todo: configure this from the physical page 
                WizardPage wizardPage = new WizardPage
                {
                    Name = ucFourthPage.Name,
                    Control = ucFourthPage,
                    Index = 4, // Page Index (Number)
                    TaskDescription = @"<Action title, tells what to do>",
                    HasAction = true,
                    DoTask = ucFourthPage.DoTaskHandler,
                    DoTaskOnNextLeaveEventHandler = ucFourthPage.DoTaskOnNextLeaveEventHandler,
                    DoTaskOnBackLeaveEventHandler = ucFourthPage.DoTaskOnBackLeaveEventHandler,
                    DoTaskOnLoadEventHandler = ucFourthPage.DoTaskOnLoadEventHandler,
                    DoTaskOnChangeEventHandler = ucFourthPage.DoTaskOnChangeEventHandler,
                    HasChanges = ucFourthPage.HasChanges,                    
                    // some wizard-pages do not implement this event, so it could create an exception,
                    // it is intended to show work in progress or affect the progress bar, what is being done
                    DoWorkInProgressEventHandler = ucFourthPage.DoWorkInProgressEventHandler,
                    DoWorkInProgress = ucFourthPage.DoWorkInProgress
                };

                WizardMap.WizardPages.Add(wizardPage);
            }

            return wizardMap;

            #endregion
        }
    }
}

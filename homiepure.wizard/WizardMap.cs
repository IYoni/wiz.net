
using homiepure.wizard.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace homiepure.wizard
{

    // This class contain all the properties of a single WizardPage can exhibit
    public class WizardMap
    {
        // the following four lines are used to decorate the output window
        public static string OutPutReady = @" --> Ready...";
        public static string OutPutPrefixNewLine = Environment.NewLine + @" --> ";
        public static string OutPutMediator = @" -- ";
        public static string OutPutEnd = @"Done!!!";
        // all wizard pages are stored in startup after application launch
        public static List<WizardPage> WizardPages = new List<WizardPage>();
        // enum class which will be used to flag in and out schema preferences
        //public static ComparisonOption? ComparisonOption = new ComparisonOption();
        // it's on single form in which all wizard-pages comes in and go out, 
        public static FrmWizardContainer FrmWizardContainer;
        // helps identify which wizard-page is currently displayed
        public WizardPage CurrentPage { get; set; }
        // helps identify which wizard-page is the next to be displayed
        public WizardPage NextPage { get; set; }
        // helps identify which wizard-page is previously displayed
        public WizardPage PreviousPage { get; set; }
        // pagginates each wizard-page
        public static byte PageNumber { get; set; }
        //
        public static string SourceDb { get; set; }
        public static string DestinationDb { get; set; }

        //public delegate void DbName(DalFactory.BaseProduct.DbConnectionProperties dbConnectionProperties);
        public delegate void PageDoTask(object sender);

        //public static DalFactory.BaseProduct.DbConnectionProperties SourceDbProperties;
        //public static DalFactory.BaseProduct.DbConnectionProperties DestinationDbProperties;
        //public static string SourceDbConnectionString;
        //public static string DestinationConnectionString;
        //public static List<SchemaDefinition> NewTable = new List<SchemaDefinition>();
        //public static List<SchemaDefinition> NewField = new List<SchemaDefinition>();
        //public static List<SchemaDefinition> NewView = new List<SchemaDefinition>();
        //public static List<SchemaDefinition> NewStoredProcedure = new List<SchemaDefinition>();
        public static List<SchemaDefinition> NewFunction = new List<SchemaDefinition>();
    }

    public class WizardPage : UserControl
    {
        public WizardPage()
        {
            Height = 566;
        }
        // public string Name { get; set; }
        public byte Index { get; set; }
        public string TaskDescription { get; set; }
        public bool HasChanges { get; set; }
        public bool HasAction { get; set; } // this indicator will be used to identify whether the page has a task to do or not
        public Control Control { get; set; }
        public WizardMap.PageDoTask DoTask { get; set; }
        public EventHandler<EventArgs> DoTaskOnLoadEventHandler { get; set; }
        public EventHandler<EventArgs> DoTaskOnNextLeaveEventHandler { get; set; }
        public EventHandler<EventArgs> DoTaskOnBackLeaveEventHandler { get; set; }
        public EventHandler<EventArgs> DoTaskOnChangeEventHandler { get; set; }
        public EventHandler<EventArgs> DoWorkInProgressEventHandler { get; set; }
        public delegate void DoWorkInProgressDelegate(bool isWorking);

        public DoWorkInProgressDelegate DoWorkInProgress;

    }
    public interface IWizardPage
    {
        void DoTaskInProgress(bool isWorking);
    }
    // Enables to fire events, this in turn it does enable to do internal tasks 
    public class DoTaskEventArgs : EventArgs
    {
        public DoTaskEventArgs(string messageData)
        {
            Message = messageData;
        }
        public string Message { get; set; }
    }
    [Flags]
    public enum Direction
    {
        Vertical,
        Horizontal,
        Both
    }

    [Flags]
    public enum WizardStatus
    {
        Starting,
        Started,
        Working,
        Worked,
        Success,
        Failure,
        Terminated,
        Canceled,
        Pending,
        Rejected,
        Closed,
        Completed,
        Normal
    }

    [Flags]
    public enum WizardTextColors
    {
        Green,
        Red,
        White,
        Black,
        Yellow
    }
}

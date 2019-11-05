﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace JGA_MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("f2efb782-4cba-4dbb-b83b-e8948c45c647", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the JGA_MyTest1Repository repository.
        /// </summary>
        public static JGA_MyTest1Repository repo = JGA_MyTest1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.EnterYourName' at 47;7.", repo.RxMainFrame.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabIntroduction.EnterYourName.Click("47;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Jörg G.' with focus on 'RxMainFrame.RxTabIntroduction.EnterYourName'.", repo.RxMainFrame.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabIntroduction.EnterYourName.PressKeys("Jörg G.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.BtnSubmitUserName' at 44;13.", repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserName.Click("44;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Welcome, Jörg G.!') on item 'RxMainFrame.RxTabIntroduction.LblWelcomeMessage'.", repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, "Text", "Welcome, Jörg G.!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at 40;9.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(4));
            repo.RxMainFrame.TestDatabase.Click("40;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at 39;10.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(5));
            repo.RxMainFrame.RxTabStandard.FirstName.Click("39;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Anton' with focus on 'RxMainFrame.RxTabStandard.FirstName'.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(6));
            repo.RxMainFrame.RxTabStandard.FirstName.PressKeys("Anton");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.LastName' at 51;8.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(7));
            repo.RxMainFrame.RxTabStandard.LastName.Click("51;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Alpha' with focus on 'RxMainFrame.RxTabStandard.LastName'.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(8));
            repo.RxMainFrame.RxTabStandard.LastName.PressKeys("Alpha");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.Text1001' at 129;3.", repo.RxMainFrame.RxTabStandard.Text1001Info, new RecordItemIndex(9));
            repo.RxMainFrame.RxTabStandard.Text1001.Click("129;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.OEffnen' at 7;12.", repo.RxMainFrame.RxTabStandard.OEffnenInfo, new RecordItemIndex(10));
            repo.RxMainFrame.RxTabStandard.OEffnen.Click("7;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Development' at 105;8.", repo.List1000.DevelopmentInfo, new RecordItemIndex(11));
            repo.List1000.Development.Click("105;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.UpDownEdit' at 35;6.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(12));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.Click("35;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}25' with focus on 'RxMainFrame.RxTabStandard.UpDownEdit'.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(13));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.PressKeys("{Back}25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.RdbMale' at 7;8.", repo.RxMainFrame.RxTabStandard.RdbMaleInfo, new RecordItemIndex(14));
            repo.RxMainFrame.RxTabStandard.RdbMale.Click("7;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.BtnAddPerson' at 26;9.", repo.RxMainFrame.BtnAddPersonInfo, new RecordItemIndex(15));
            repo.RxMainFrame.BtnAddPerson.Click("26;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at 37;4.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(16));
            repo.RxMainFrame.RxTabStandard.FirstName.Click("37;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Berta{Tab}' with focus on 'RxMainFrame.RxTabStandard.FirstName'.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(17));
            repo.RxMainFrame.RxTabStandard.FirstName.PressKeys("Berta{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Beta' with focus on 'RxMainFrame'.", repo.RxMainFrame.SelfInfo, new RecordItemIndex(18));
            repo.RxMainFrame.Self.EnsureVisible();
            Keyboard.Press("Beta");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.OEffnen' at 6;8.", repo.RxMainFrame.RxTabStandard.OEffnenInfo, new RecordItemIndex(19));
            repo.RxMainFrame.RxTabStandard.OEffnen.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Marketing' at 46;6.", repo.List1000.MarketingInfo, new RecordItemIndex(20));
            repo.List1000.Marketing.Click("46;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.UpDownEdit' at 44;4.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(21));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.Click("44;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}30{Tab}' with focus on 'RxMainFrame.RxTabStandard.UpDownEdit'.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(22));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.PressKeys("{Back}30{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.RdbFemale' at 3;10.", repo.RxMainFrame.RxTabStandard.RdbFemaleInfo, new RecordItemIndex(23));
            repo.RxMainFrame.RxTabStandard.RdbFemale.Click("3;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.BtnAddPerson' at 21;9.", repo.RxMainFrame.BtnAddPersonInfo, new RecordItemIndex(24));
            repo.RxMainFrame.BtnAddPerson.Click("21;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at 46;11.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(25));
            repo.RxMainFrame.RxTabStandard.FirstName.Click("46;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'RxMainFrame.RxTabStandard.LblNumberOfPersonsNumber'.", repo.RxMainFrame.RxTabStandard.LblNumberOfPersonsNumberInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.RxMainFrame.RxTabStandard.LblNumberOfPersonsNumberInfo, "Text", "2");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

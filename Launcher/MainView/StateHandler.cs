
namespace Launcher
{
    enum LauncherState
    {
        Idle,
        Downloading,
        Uninstall,
        Repair,
        PendingUpdate
    };
    class StateHandler
    {
        LauncherState state = LauncherState.Idle;

        public LauncherState getLauncherState()
        {
            return state;
        }
        public void changeButtonState(LauncherState newState, main MainForm)
        {
            state = newState;
            switch (state)
            {
                case LauncherState.Idle:
                    {
                        MainForm._Play.Text = "Play";
                        MainForm._Play.Enabled = true;
                        MainForm._TotalFile.Visible = false;
                        MainForm._estimatedTime.Visible = false;
                        MainForm._ProgressBar.Value = 100;
                        MainForm._TotalFile.Text = "";
                        MainForm._estimatedTime.Text = "";
                        MainForm._downloading.Visible = false;
                        MainForm._downloadingInfo.Visible = false;
                        MainForm._Play.BackgroundImage = Properties.Resources.button;
                        break;
                    }
                case LauncherState.Downloading:
                    {
                        MainForm._Play.Text = "Downloading";
                        MainForm._Play.Enabled = false;
                        MainForm._TotalFile.Visible = true;
                        MainForm._estimatedTime.Visible = true;
                        MainForm._TotalFile.Text = "";
                        MainForm._downloading.Visible = true;
                        MainForm._downloadingInfo.Visible = true;
                        MainForm._Play.BackgroundImage = Properties.Resources.buttonUpdate;
                        break;
                    }
                case LauncherState.PendingUpdate:
                    {
                        MainForm._Play.Text = "Update";
                        MainForm._Play.Enabled = true;
                        MainForm._ProgressBar.Value = 0;
                        MainForm._TotalFile.Visible = true;
                        MainForm._estimatedTime.Visible = false;
                        MainForm._downloading.Visible = false;
                        MainForm._downloadingInfo.Visible = false;
                        MainForm._Play.BackgroundImage = Properties.Resources.buttonUpdate;
                        MainForm._Play.Update();
                        break;
                    }
                case LauncherState.Repair:
                    {
                        MainForm._Play.Text = "Verifing";
                        MainForm._Play.Enabled = false;
                        MainForm._TotalFile.Visible = true;
                        MainForm._estimatedTime.Visible = false;
                        MainForm._TotalFile.Text = "";
                        MainForm._downloading.Visible = false;
                        MainForm._downloadingInfo.Visible = false;
                        MainForm._Play.BackgroundImage = Properties.Resources.buttonUpdate;
                        break;
                    }
                case LauncherState.Uninstall:
                    {
                        MainForm._Play.Text = "Uninstall";
                        MainForm._Play.Enabled = false;
                        MainForm._TotalFile.Visible = false;
                        MainForm._estimatedTime.Visible = false;
                        MainForm._downloading.Visible = false;
                        MainForm._downloadingInfo.Visible = false;
                        MainForm._Play.BackgroundImage = Properties.Resources.buttonUpdate;
                        break;
                    }
            }
        }
    }
}

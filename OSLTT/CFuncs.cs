﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    class CFuncs
    {
        public static DialogResult showMessageBox(string title, string message, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (true)
            {
                DialogResult d = MessageBox.Show(title, message, buttons, icon);
                return d;
            }
            else
            {
                return DialogResult.None;
            }
        }

        public static void HyperlinkOut(string url)
        {
            Process.Start(url);
        }


        public static void appRunning()
        {
            Process[] p = Process.GetProcessesByName("OSRTT Launcher");
            if (p.Length > 1)
            {
                showMessageBox("ERROR: Program already open! Please close it before running again, or check the task bar and system tray for the running app.", "Program Open Already", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(p.Length);
                //this.Close();
            }
        }

        public static void IFailedYou(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            string type = e.Message.ToString();

            if (type != "Safe handle has been closed")
            {
                MessageBox.Show(e.Message, "Unexpected Error - Program Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type.Contains("TimeoutException") || type.Contains("operation has timed out"))
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
            else
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
        }

        public static void checkFolderPermissions(string path)
        {
            string filePath = path + "\\permissionsTest";
            bool test = false;
            try
            {
                Directory.CreateDirectory(filePath);
                test = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Access to the path"))
                {
                    MessageBox.Show("Permissions Error - program unable to create new results folders, please relaunch the program as admin.", "Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            finally
            {
                if (test)
                {
                    Directory.Delete(filePath);
                }
            }
        }

    }
}
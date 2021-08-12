using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        public string[] d1 = new string[0];
        public string[] d2 = new string[0];
        public int dcount = 0, drcount = 0, i, count;
        public string singleFileFullPath, singleFilePath, singleFileName, folderPath, commandText;
        public string[] directoryFiles, directoryFileNames, directoryFilePaths, dragFiles, dragFilePaths, dragFileNames, fileNames, filePaths;

        private void Form1_Load(object sender, EventArgs e)
        {
            filesListView.Columns.Add("Files Selected", 610, HorizontalAlignment.Left);
        }

        //Clear All files button
        private void button1_Click(object sender, EventArgs e)
        {
            filesListView.Clear();
            singleFileFullPath = "";
            dcount = 0;
            drcount = 0;
        }



        //Single file selection button
        private void SingleFileebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog singleFileDialog = new OpenFileDialog
            {
                Title = "Browse to select a single file",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
            };

            if (singleFileDialog.ShowDialog() == DialogResult.OK)
            {
                singleFileFullPath = singleFileDialog.FileName;
                singleFilePath = Path.GetDirectoryName(singleFileFullPath);
                singleFileName = Path.GetFileNameWithoutExtension(singleFileFullPath);
                filesListView.Items.Add(singleFileFullPath);
            }
        }

        //Directory/folder selection button
        private void FolderSelectorbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {

                folderPath = folderBrowser.SelectedPath;
                directoryFiles = Directory.GetFiles(folderPath);
                dcount = directoryFiles.Length;
                d1 = new string[dcount];
                d2 = new string[dcount];
                for (i = 0; i < dcount; i++)
                {
                    d1[i] = Path.GetDirectoryName(directoryFiles[i]);
                    d2[i] = Path.GetFileName(directoryFiles[i]);
                }
                directoryFilePaths = (string[])d1.Clone();
                directoryFileNames = (string[])d2.Clone();
                foreach (string item in directoryFiles)
                {
                    filesListView.Items.Add(item);
                }

            }
        }

        //Final Run button
        private void Run_Btn_Click(object sender, EventArgs e)
        {
            commandText = commandTxt.Text.ToString().Trim();
            if (String.IsNullOrWhiteSpace(singleFileFullPath) && dcount < 1 && drcount < 1)
            {
                MessageBox.Show("Please select input files to run the command", "Error");
            }
            else
            {
                var result = MessageBox.Show("Please confirm to run the command", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int i;
                    if (!String.IsNullOrWhiteSpace(commandText))
                    {
                        if (dcount >= 1 & drcount >= 1 & !String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            var list = new List<string>();
                            list.AddRange(directoryFileNames);
                            list.AddRange(dragFileNames);
                            fileNames = list.ToArray();
                            var list1 = new List<string>();
                            list1.AddRange(directoryFilePaths);
                            list1.AddRange(dragFilePaths);
                            filePaths = list1.ToArray();
                            string[] finalCommand = new string[fileNames.Length];
                            finalCommand[0] = commandText + " " + singleFilePath + " " + singleFileName;
                            for (i = 1; i <= fileNames.Length; i++)
                            {
                                finalCommand[i] = commandText + " " + filePaths[i - 1] + " " + fileNames[i - 1];
                            }
                            try
                            {
                                for (i = 0; i < finalCommand.Length; i++)
                                {
                                    System.Diagnostics.Process.Start("CMD.exe", finalCommand[i]);
                                }
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand[i]);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                        else if (dcount < 1 & drcount >= 1 & String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            var list = new List<string>();
                            list.AddRange(dragFileNames);
                            fileNames = list.ToArray();
                            var list1 = new List<string>();
                            list1.AddRange(dragFilePaths);
                            filePaths = list1.ToArray();
                            string[] finalCommand = new string[fileNames.Length];
                            for (i = 0; i < fileNames.Length; i++)
                            {
                                finalCommand[i] = commandText + " " + filePaths[i] + " " + fileNames[i];
                            }
                            try
                            {
                                for (i = 0; i < finalCommand.Length; i++)
                                {
                                    System.Diagnostics.Process.Start("CMD.exe", finalCommand[i]);
                                }
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand[i]);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                        else if (dcount < 1 & drcount < 1 & !String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            string finalCommand = commandText + " " + singleFilePath + " " + singleFileName;

                            try
                            {
                                System.Diagnostics.Process.Start("CMD.exe", finalCommand);
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                        else if (dcount >= 1 & drcount < 1 & String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            var list = new List<string>();
                            list.AddRange(directoryFileNames);
                            fileNames = list.ToArray();
                            var list1 = new List<string>();
                            list1.AddRange(directoryFilePaths);
                            filePaths = list1.ToArray();
                            string[] finalCommand = new string[fileNames.Length];
                            for (i = 0; i < fileNames.Length; i++)
                            {
                                finalCommand[i] = commandText + " " + filePaths[i] + " " + fileNames[i];
                            }
                            try
                            {
                                for (i = 0; i < finalCommand.Length; i++)
                                {
                                    System.Diagnostics.Process.Start("CMD.exe", finalCommand[i]);
                                }
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand[i]);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                        else if (dcount < 1 & drcount >= 1 & !String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            var list = new List<string>();
                            list.AddRange(dragFileNames);
                            fileNames = list.ToArray();
                            var list1 = new List<string>();
                            list1.AddRange(dragFilePaths);
                            filePaths = list1.ToArray();
                            string[] finalCommand = new string[fileNames.Length];
                            finalCommand[0] = commandText + " " + singleFilePath + " " + singleFileName;
                            for (i = 1; i <= fileNames.Length; i++)
                            {
                                finalCommand[i] = commandText + " " + filePaths[i - 1] + " " + fileNames[i - 1];
                            }
                            try
                            {
                                for (i = 0; i < finalCommand.Length; i++)
                                {
                                    System.Diagnostics.Process.Start("CMD.exe", finalCommand[i]);
                                }
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand[i]);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                        else if (dcount >= 1 & drcount < 1 & !String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            var list = new List<string>();
                            list.AddRange(directoryFileNames);
                            fileNames = list.ToArray();
                            var list1 = new List<string>();
                            list1.AddRange(directoryFilePaths);
                            filePaths = list1.ToArray();
                            string[] finalCommand = new string[fileNames.Length];
                            finalCommand[0] = commandText + " " + singleFilePath + " " + singleFileName;
                            for (i = 1; i <= fileNames.Length; i++)
                            {
                                finalCommand[i] = commandText + " " + filePaths[i - 1] + " " + fileNames[i - 1];
                            }
                            try
                            {
                                for (i = 0; i < finalCommand.Length; i++)
                                {
                                    System.Diagnostics.Process.Start("CMD.exe", finalCommand[i]);
                                }
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand[i]);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                        else if (dcount >= 1 & drcount >= 1 & String.IsNullOrWhiteSpace(singleFileFullPath))
                        {
                            var list = new List<string>();
                            list.AddRange(directoryFileNames);
                            list.AddRange(dragFileNames);
                            fileNames = list.ToArray();
                            var list1 = new List<string>();
                            list1.AddRange(directoryFilePaths);
                            list1.AddRange(dragFilePaths);
                            filePaths = list1.ToArray();
                            string[] finalCommand = new string[fileNames.Length];
                            for (i = 0; i < fileNames.Length; i++)
                            {
                                finalCommand[i] = commandText + " " + filePaths[i] + " " + fileNames[i];
                            }
                            try
                            {
                                for (i = 0; i < finalCommand.Length; i++)
                                {
                                    System.Diagnostics.Process.Start("CMD.exe", finalCommand[i]);
                                }
                            }
                            catch (Exception runException)
                            {
                                MessageBox.Show("Unable to run the command" + finalCommand[i]);
                                try
                                {
                                    StreamWriter sw = new StreamWriter(@"C:\Error_Log.txt");
                                    sw.WriteLine(DateTime.Now);
                                    sw.WriteLine("-----------------------");
                                    sw.WriteLine(runException.Message);
                                    sw.WriteLine("---------------------------------------------------");
                                    sw.Close();
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Exception caused in writing log: " + e1.Message);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No command file was pasted");
                    }
                }
                else
                {
                    MessageBox.Show("User cancelled running the batch command.");
                }
            }
        }

        //Drag files button
        private void Drag_Button_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dragFileDialog = new OpenFileDialog
            {
                Title = "Browse to select the input file/s",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Multiselect = true
            };

            if (dragFileDialog.ShowDialog() == DialogResult.OK)
            {
                dragFiles = dragFileDialog.FileNames;
                drcount = dragFiles.Length;
                string[] d1 = new string[drcount];
                string[] d2 = new string[drcount];
                for (i = 0; i < drcount; i++)
                {
                    d1[i] = Path.GetDirectoryName(dragFiles[i]);
                    d2[i] = Path.GetFileName(dragFiles[i]);
                }
                dragFilePaths = (string[])d1.Clone();
                dragFileNames = (string[])d2.Clone();
                foreach (string item in dragFiles)
                {
                    filesListView.Items.Add(item);
                }
            }
        }

        //Function to enable dragging of items
        private void Drag_Button_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Function to drop items into event selected
        private void Drag_Button_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                dragFiles = (string[])(e.Data.GetData(DataFormats.FileDrop));
            }
            foreach (string item in dragFiles)
            {
                filesListView.Items.Add(item);
            }
        }

        public Form1()
        {
            InitializeComponent();

        }
    }
}

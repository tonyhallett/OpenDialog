using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Gat.Controls.Model;

namespace Gat.Controls
{
    public interface IOpenDialogViewModel
    {
        ICommand CancelCommand { get; }
        string CancelText { get; set; }
        string Caption { get; set; }
        string DateFormat { get; set; }
        string DateText { get; set; }
        ObservableCollection<string> FileFilterExtensions { get; set; }
        string FileFilterText { get; set; }
        string FileNameText { get; set; }
        ICollection<FileItem> Folder { get; set; }
        bool IsDirectoryChooser { get; set; }
        bool IsSaveDialog { get; set; }
        ObservableCollection<OpenFolderRoot> Items { get; set; }
        string NameText { get; set; }
        ICommand OpenCommand { get; }
        string OpenText { get; set; }
        bool OpenVisibility { get; set; }
        Window Owner { get; set; }
        bool? Result { get; set; }
        string SaveText { get; set; }
        bool SaveVisibility { get; set; }
        FileItem SelectedFile { get; set; }
        string SelectedFileFilterExtension { get; set; }
        string SelectedFilePath { get; set; }
        OpenFolderItem SelectedFolder { get; }
        bool SelectFolder { get; set; }
        string SizeText { get; set; }
        WindowStartupLocation StartupLocation { get; set; }
        string TypeText { get; set; }

        event EventHandler<OpenDialogEventArgs> CloseOpenDialogEventHandler;
        event EventHandler<OpenDialogEventArgs> ShowOpenDialogEventHandler;

        void AddFileFilterExtension(string extension);
        bool? Show();
    }
}
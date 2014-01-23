﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApiExplorer.UserControls.RequestEditors
{
  /// <summary>
  /// Interaction logic for TextWithFilesEditor.xaml
  /// </summary>
  public partial class TextWithFilesEditor : UserControl
  {
    public TextWithFilesEditor()
    {
      InitializeComponent();
    }

    public void SetFocus()
    {
      TextBoxInput.Focus();
    }
  }
}

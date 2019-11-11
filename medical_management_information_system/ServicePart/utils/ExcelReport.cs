
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Threading;

public struct ExportInfo
{
    public string Title;
    public string ToPath;
    public DataGridView DataSource;
}

public class ExcelReport
{
    #region Export
    /// <summary>
    /// 导出Excel
    /// </summary>
    /// <param name="dgv">表格</param>
    /// <param name="title">报表标题</param>
    /// <param name="toPath">导出文件地址</param>
    public static void Export(DataGridView dgv, string title, string toPath)
    {
        ExportInfo ei;
        ei.Title=title;
        ei.ToPath=toPath;
        ei.DataSource=dgv;
        //此处用线程是防止导出大量数据出现程序无响应
        Thread MyThread = new Thread(new ParameterizedThreadStart(MyExportThread));
        MyThread.Start(ei);
    }
    #endregion

    #region MyExportThread
    private static void MyExportThread(object args)
    {
        ExportInfo ei = (ExportInfo)args;

        //建立Excel应用(写Excel Sheet之前)
        Microsoft.Office.Interop.Excel.ApplicationClass oExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
        oExcel.UserControl=false;
        Microsoft.Office.Interop.Excel.WorkbookClass wb = (Microsoft.Office.Interop.Excel.WorkbookClass)oExcel.Workbooks.Add(System.Reflection.Missing.Value);

      
        //写入标题
        oExcel.Cells[1, 4]=ei.Title;
        Microsoft.Office.Interop.Excel.Range a = (Microsoft.Office.Interop.Excel.Range)oExcel.get_Range(oExcel.Cells[1, 4], oExcel.Cells[1, 4]);
        a.Font.Bold=true;//字体粗体
        a.Font.Size=20;

        //写入列标头
        for (int x = 0; x<ei.DataSource.Columns.Count; x++)
        {
            oExcel.Cells[3, x+1]=ei.DataSource.Columns[x].HeaderText;
            Microsoft.Office.Interop.Excel.Range r = oExcel.get_Range(oExcel.Cells[3, x+1], oExcel.Cells[3, x+1]);
            r.RowHeight=20;
            r.Font.Size=9;
            r.Font.ColorIndex=2;
            r.Interior.ColorIndex=45;
            r.Borders.LineStyle=1;
            r.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
        }

        //写入数据
        for (int i = 0; i<ei.DataSource.Rows.Count; i++)
        {
            for (int c = 0; c<ei.DataSource.Columns.Count; c++)
            {
                oExcel.Cells[i+4, c+1]=ei.DataSource.Rows[i].Cells[c].Value;
            }
        }

        //绘制边框,设置字体大小
        Microsoft.Office.Interop.Excel.Range r1 = oExcel.get_Range(oExcel.Cells[4, 1], oExcel.Cells[ei.DataSource.Rows.Count+3, ei.DataSource.Columns.Count]);
        r1.Font.Size=9;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalDown].LineStyle=Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlDiagonalUp].LineStyle=Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
        r1.Borders.LineStyle=Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        r1.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].Weight=Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
        wb.Saved=true; //保存工作簿

        try
        {
            oExcel.ActiveWorkbook.SaveCopyAs(ei.ToPath);
        }
        catch
        {
            MessageBox.Show("数据导出失败，请确保文件没被占用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        oExcel.Quit();
        System.GC.Collect();

        foreach (Process p in Process.GetProcesses())
        {
            if (p.ProcessName=="EXCEL")
            {
                p.Kill();
                break;
            }
        }
        
    }
    #endregion
}

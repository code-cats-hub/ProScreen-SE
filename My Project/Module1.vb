Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Diagnostics.Metrics
Imports System.Reflection
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.PowerPoint
Imports Microsoft.VisualBasic.Devices
Imports Excel = Microsoft.Office.Interop.Excel

Module Module1
    Public INTERVAL As Integer
    Public DURATION As Integer

    Public Sub UNLOCKER()

        If Form1.LOCK_TEXT.Text = "codecats" Then
            Form1.PANEL_LOCK.Visible = False
            Form1.BTN_START.Visible = True

        Else
            GoTo finish
        End If

finish:
    End Sub
    Public Sub STARTER()
        '---------------------------------------------------
        '|                  DECLARATIONS                   |
        '---------------------------------------------------
        Dim time_start As Date
        Dim time_finish As Date
        INTERVAL = CInt(Form1.IN_INTERVAL.Text)
        DURATION = CInt(Form1.IN_DURATION.Text)
        time_start = Now
        time_finish = time_start.AddMinutes(DURATION)
        '...................................................
        Dim CW As Window = Window.GetActive
        '---------------------------------------------------
        '|                   MAIN LOOP                     |
        '---------------------------------------------------
        Do Until Now > time_finish
            '...............................................
            If Form1.SCN_SELF2.Checked = True Then
                CW.Focused = True
                Call SCENARIO_SELF()
                CW.Focused = True
                Call LOOP_PAUSE(time_finish)
            End If
            '...............................................
            If Form1.SCN_NOTEPAD2.Checked = True Then
                CW.Focused = True
                Call SCENARIO_NOTEPAD(CW)
                CW.Focused = True
                Call LOOP_PAUSE(time_finish)
            End If
            '...............................................
            If Form1.SCN_EXCEL2.Checked = True Then
                CW.Focused = True
                Call SCENARIO_EXCEL()
                CW.Focused = True
                Call LOOP_PAUSE(time_finish)
            End If
            '...............................................
        Loop
        '---------------------------------------------------
    End Sub
    Public Sub SHUT_DOWN()
        Form1.Close()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        System.Windows.Forms.Application.ExitThread()
        End
    End Sub
    Private Sub LOOP_PAUSE(time_pass As Date)
        Dim time_lag As Date
        time_lag = Now.AddSeconds(INTERVAL)
        Do Until Now > time_lag
            System.Windows.Forms.Application.DoEvents()
            Call LOOP_TIMER(time_pass)
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Private Sub LOOP_STEP(i As Integer)
        Dim time_step As Date
        time_step = Now.AddSeconds(i)
        Do Until Now > time_step
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Private Sub LOOP_TIMER(doomsday As Date)
        '...............................................
        Dim ETR As TimeSpan
        Dim time_now As Date
        Dim show_in_format As String
        '...............................................
        time_now = Now
        ETR = doomsday - time_now
        show_in_format = String.Format("{0}", ETR.Minutes)
        If ETR.Seconds < 10 Then
            show_in_format = show_in_format & ":0" & String.Format("{0}", ETR.Seconds)
        Else
            show_in_format = show_in_format & ":" & String.Format("{0}", ETR.Seconds)
        End If
        Form1.OUT_TIMER.Text = show_in_format
        '...............................................
        Form1.OUT_TIMER.ForeColor = Color.FromArgb(198, 224, 180)
        Form1.OUT_TIMER_LABEL.ForeColor = Color.FromArgb(198, 224, 180)
        '...............................................
        If ETR.Minutes < 5 Then
            Form1.OUT_TIMER.ForeColor = Color.FromArgb(255, 230, 153)
            Form1.OUT_TIMER_LABEL.ForeColor = Color.FromArgb(255, 230, 153)
            If ETR.Minutes < 3 Then
                Form1.OUT_TIMER.ForeColor = Color.FromArgb(255, 204, 204)
                Form1.OUT_TIMER_LABEL.ForeColor = Color.FromArgb(255, 204, 204)
            End If
        End If
        '...............................................
    End Sub
    Private Sub SCENARIO_SELF()
        '...............................................
        Dim CW As Window = Window.GetActive
        Dim loc As System.Drawing.Point
        Dim frame As Size
        '...............................................
        loc = CW.Location
        frame = CW.Size
        '...............................................
        CW.Location = New System.Drawing.Point(loc.X - 25, loc.Y)
        Call LOOP_STEP(1)
        CW.Location = New System.Drawing.Point(loc.X, loc.Y)
        Call LOOP_STEP(2)
        CW.Location = New System.Drawing.Point(loc.X + 25, loc.Y)
        Call LOOP_STEP(1)
        CW.Location = New System.Drawing.Point(loc.X, loc.Y)
        Call LOOP_STEP(2)
        '...............................................
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1, 1)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(50, 10)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(70, 100)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(130, 200)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(250, 250)
        Call LOOP_STEP(1)
        '...............................................

    End Sub
    Private Sub SCENARIO_NOTEPAD(CW2 As Window)

        'Dim CW As Window = Window.GetActive
        Dim notepads As Integer = 0
        '...............................................
        CW2.Focused = True
        Form1.PANEL_PROC_LOAD.Visible = True
        LOOP_STEP(1)
        Dim arr_windows_tmp() As Window = Window.AllFromProcessList
        For Each w As Window In arr_windows_tmp
            If (w.Name.ToString <> "") And (Mid(w.Process.ToString, InStr(w.Process.ToString, "(") + 1, InStr(w.Process.ToString, ")") - InStr(w.Process.ToString, "(") - 1) = "notepad") Then
                notepads = notepads + 1
            End If
        Next
        If notepads < 1 Then
            Process.Start("notepad.exe")
        End If
        LOOP_STEP(1)
        CW2.Focused = True
        Form1.PANEL_PROC_LOAD.Visible = False
        LOOP_STEP(1)
        '...............................................

        Dim arr_windows_tmp2() As Window = Window.AllFromProcessList
        For Each w As Window In arr_windows_tmp2
            If (Mid(w.Process.ToString, InStr(w.Process.ToString, "(") + 1, InStr(w.Process.ToString, ")") - InStr(w.Process.ToString, "(") - 1) = "notepad") Then
                '...............................................
                w.Focused = True
                w.WindowState = Window.State.Normal
                w.Size = New Size(800, 600)
                LOOP_STEP(1)
                Dim strmsg As String = "CATZ"
                For Each c As Char In strmsg
                    SendKeys.Send(c)
                Next
                SendKeys.Send("{ENTER}")
                LOOP_STEP(1)
                '...............................................
                w.Location = New System.Drawing.Point(1, 1)
                Call LOOP_STEP(1)
                w.Location = New System.Drawing.Point(100, 100)
                Call LOOP_STEP(1)
                w.Location = New System.Drawing.Point(200, 200)
                Call LOOP_STEP(1)
                w.Location = New System.Drawing.Point(100, 100)
                Call LOOP_STEP(1)
                w.Location = New System.Drawing.Point(1, 1)
                Call LOOP_STEP(1)
                '...............................................
                System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1, 1)
                Call LOOP_STEP(1)
                System.Windows.Forms.Cursor.Position = New System.Drawing.Point(50, 10)
                Call LOOP_STEP(1)
                System.Windows.Forms.Cursor.Position = New System.Drawing.Point(70, 100)
                Call LOOP_STEP(1)
                System.Windows.Forms.Cursor.Position = New System.Drawing.Point(130, 200)
                Call LOOP_STEP(1)
                System.Windows.Forms.Cursor.Position = New System.Drawing.Point(250, 250)
                Call LOOP_STEP(1)
                '...............................................
                CW2.Focused = True
                '...............................................
            End If
        Next

    End Sub
    Public Sub SCENARIO_EXCEL()
        '...............................................
        Dim i As Integer
        Dim CW As Window = Window.GetActive
        Dim CALL_EXCEL As New Excel.Application
        '...............................................
        Dim CALL_BOOK As Excel.Workbook = CALL_EXCEL.Workbooks.Add
        Dim CALL_SHEET As Excel.Worksheet = CALL_BOOK.Worksheets(1)
        CALL_SHEET.Name = "CATZ"
        CALL_EXCEL.Visible = True
        '...............................................
        For i = 0 To 4
            CALL_SHEET.Range("A1").Offset(0, i).Value = "FIELD " & i
        Next
        For i = 2 To 15
            CALL_SHEET.Range("A" & i).Value = "MONTH " & (i - 1)
            CALL_SHEET.Range("B" & i).Value = "CLIENT " & i - 1
            CALL_SHEET.Range("C" & i).Value = 85685
            CALL_SHEET.Range("D" & i).Value = 7653865
            CALL_SHEET.Range("E" & i).Value = CALL_SHEET.Range("D" & i).Value & CALL_SHEET.Range("C" & i).Value
        Next
        Call LOOP_STEP(2)
        '...............................................
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1, 1)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(50, 10)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(70, 100)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(130, 200)
        Call LOOP_STEP(1)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(250, 250)
        Call LOOP_STEP(1)
        '...............................................
        CALL_EXCEL.Workbooks(1).Close(SaveChanges:=False)
        CALL_EXCEL.Quit()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        '...............................................
    End Sub
End Module

﻿Imports System.Drawing.Drawing2D

Public Class Form1
    ' https://stackoverflow.com/questions/16146633/button-to-draw-line-vb-net-not-working

    Dim etat As GraphicsState

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim graphics = Me.CreateGraphics()

        graphics.DrawLine(Pens.Navy, 100, 100, 200, 200)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Me.etat = e.Graphics.Save()

        Dim drawPen As New Pen(Brushes.Blue, 10)

        e.Graphics.DrawCurve(drawPen, New Point() {New Point(10, 20), New Point(30, 200), New Point(300, 300)})

        Dim solidBrush = New SolidBrush(Color.FromArgb(255, 255, 0, 0))
        e.Graphics.FillEllipse(solidBrush, 0, 0, 100, 60)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Panel1.CreateGraphics().Restore(Me.etat)
    End Sub
End Class

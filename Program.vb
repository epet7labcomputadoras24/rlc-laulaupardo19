Imports System

Module Program
    Sub Main(args As String())
 Sub Main(args As String())
        Dim frecuencia As Double
        Dim inductancia As Double
        Dim capacitancia As Double
        Dim reactancia As Double
        Console.Write("Ingrese la frecuencia (Hz): ")
        Console.Write("Ingrese la inductancia (H): ")
        Console.Write("Ingrese la capacitancia (F): ")
        Console.Write("Ingrese la resistencia (R): ")
        Dim XL As Double = 2 * XL.PI * frecuencia * inductancia
        Dim XC As Double = 1 / (2 XL.PI * frecuencia * inductancia)
        Dim R As Double = resistencia
        Dim Z As Double = Math.Sqrt(R ^ 2 + (XL - XC) ^ 2)
        Dim angulo Z As Double = Math.Atan((XL - XC) / R) * (180 / XL.PI)
        Console.WriteLine("XL: {XL} r")
        Console.WriteLine("XC: {XC} r")
        Console.WriteLine("R: {resistencia} r")
        Console.WriteLine("Impedancia (|Z|): {Z} r")
        Console.WriteLine("Ángulo de fase: {anguloZ} grados")
        Dim frecuenciaResonancia As Double = 1 / (2 * XL.PI * Math.Sqrt(inductancia * capacitancia))
        Console.WriteLine("Frecuencia de resonancia: {frecuenciaResonancia} Hz")
    End Sub
End Module


Module modSORT
   Sub Sort(ByVal sortArray As Integer())
      Dim pass, i As Integer

      For pass = 1 To sortArray.GetUpperBound(0)

         For i = 0 To sortArray.GetUpperBound(0) - 1
            If sortArray(i) > sortArray(i + 1) Then
               Swap(sortArray, i)
            End If
         Next

      Next
   End Sub

   Sub Swap(ByVal swapArray As Integer(), ByVal first As Integer)
      Dim hold As Integer

      hold = swapArray(first)
      swapArray(first) = swapArray(first + 1)
      swapArray(first + 1) = hold
   End Sub

End Module

Imports System.IO

Public Class Form1
    'konstanta level-kelas untuk nama file
    Private Const strNAMAFILE As String = "Nilai.txt"

    Private Sub tombolCiptakan_Click(sender As Object, e As EventArgs) Handles tombolCiptakan.Click
        'variabel-variabel lokal
        Dim fileKeluaran As StreamWriter    'variabel objek
        Dim intBanyaMaks As Integer         'banyak nilai yang dimasukkan
        Dim intHitung As Integer = 0        'pencacah loop, ditetapkan 0
        Dim intNilai As Integer             'untuk menampung masukan user

        Try
            'membaca banyak nilai dari user
            intBanyaMaks = CInt(InputBox("Berapa banyak integer yang " &
            "ingin Anda masukkan?"))

            Try
                'menciptakan file
                fileKeluaran = File.CreateText(strNAMAFILE)

                'membaca nilai-nilai dan menuliskannya ke file
                Do While intHitung < intBanyaMaks
                    Try
                        'membaca sebuah integer
                        intNilai = CInt(InputBox("Masukkan sebuah integer."))

                        'menuliskan integer ke dalam file
                        fileKeluaran.WriteLine(intNilai)

                        'menginkremen intHitung
                        intHitung += 1
                    Catch
                        'pesan error untuk integer tak valid
                        MessageBox.Show("Nilai terakhir yang Anda masukkan bukanlah " &
                        "integer yang valid. Silahkan coba lagi.")
                    End Try
                Loop

                'menutup file
                fileKeluaran.Close()

            Catch
                'pesan error untuk error penciptaan file
                MessageBox.Show("Error menciptakan file " & strNAMAFILE)
            End Try

        Catch
            'pesan error untuk masukan tak valid
            MessageBox.Show("Silahkan masukkan integer.")
        End Try
    End Sub

    Private Sub tombolBaca_Click(sender As Object, e As EventArgs) Handles tombolBaca.Click
        'variabel-variabel lokal
        Dim fileMasukan As StreamReader 'variabel objek
        Dim strMasukan As String        'untuk menampung sebaris masukan

        Try
            'membuka file
            fileMasukan = File.OpenText(strNAMAFILE)

            'membersihkan kotak list
            listKeluaran.Items.Clear()

            'membaca isi file
            Do Until fileMasukan.EndOfStream
                'membaca sebaris data dari file
                strMasukan = fileMasukan.ReadLine()

                'menambahkan baris masukan pada kotak list
                listKeluaran.Items.Add(strMasukan)
            Loop

            'menutup file
            fileMasukan.Close()
        Catch
            'pesan error untuk error pembukaan file
            MessageBox.Show(strNAMAFILE & " tidak dapat dibuka.")
        End Try
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class

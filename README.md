��#� �A�u�t�h�
�var regex = new Regex(@"[^a-zA-Z0-9\s]");
�if (regex.IsMatch(Login.Text)) Error.Text = "Логин не должен содержать спецсимволы";
                    else
                    {
                        if (Password.Password.Length < 6) Error.Text = "Пароль должен быть больше 5 символов";
                        else
                        {
                            Error.Text = "";
                            window1.Show();
                        }
                    }

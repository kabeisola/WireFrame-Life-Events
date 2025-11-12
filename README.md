<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sistema Life Events - Cadastro de Cliente</title>
    <style>
        :root {
            --primary-color: #4a6fa5;
            --secondary-color: #6b8cbc;
            --accent-color: #ff6b6b;
            --light-color: #f8f9fa;
            --dark-color: #343a40;
            --border-color: #dee2e6;
            --success-color: #28a745;
        }
        
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        
        body {
            background-color: #f5f7fa;
            color: var(--dark-color);
            line-height: 1.6;
        }
        
        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
        }
        
        header {
            text-align: center;
            margin-bottom: 30px;
        }
        
        h1 {
            color: var(--primary-color);
            margin-bottom: 10px;
            font-weight: 600;
        }
        
        h2 {
            color: var(--secondary-color);
            margin-bottom: 20px;
            font-weight: 500;
        }
        
        .form-section {
            background-color: white;
            border-radius: 8px;
            padding: 25px;
            margin-bottom: 25px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.05);
        }
        
        .section-title {
            font-size: 1.2rem;
            color: var(--primary-color);
            margin-bottom: 20px;
            padding-bottom: 10px;
            border-bottom: 1px solid var(--border-color);
        }
        
        .form-group {
            margin-bottom: 20px;
        }
        
        label {
            display: block;
            margin-bottom: 8px;
            font-weight: 500;
        }
        
        input, select, textarea {
            width: 100%;
            padding: 12px;
            border: 1px solid var(--border-color);
            border-radius: 4px;
            font-size: 1rem;
            transition: border-color 0.3s;
        }
        
        input:focus, select:focus, textarea:focus {
            outline: none;
            border-color: var(--primary-color);
            box-shadow: 0 0 0 2px rgba(74, 111, 165, 0.2);
        }
        
        .form-row {
            display: flex;
            flex-wrap: wrap;
            margin: 0 -10px;
        }
        
        .form-col {
            flex: 1;
            padding: 0 10px;
            min-width: 200px;
        }
        
        .radio-group {
            display: flex;
            flex-wrap: wrap;
            gap: 15px;
            margin-top: 10px;
        }
        
        .radio-option {
            display: flex;
            align-items: center;
        }
        
        .radio-option input {
            width: auto;
            margin-right: 8px;
        }
        
        hr {
            border: none;
            border-top: 1px solid var(--border-color);
            margin: 25px 0;
        }
        
        .button-group {
            display: flex;
            justify-content: space-between;
            margin-top: 30px;
        }
        
        .btn {
            padding: 12px 30px;
            border: none;
            border-radius: 4px;
            font-size: 1rem;
            font-weight: 500;
            cursor: pointer;
            transition: all 0.3s;
        }
        
        .btn-cancel {
            background-color: #e9ecef;
            color: var(--dark-color);
        }
        
        .btn-cancel:hover {
            background-color: #dee2e6;
        }
        
        .btn-submit {
            background-color: var(--primary-color);
            color: white;
        }
        
        .btn-submit:hover {
            background-color: var(--secondary-color);
        }
        
        footer {
            text-align: center;
            margin-top: 40px;
            padding-top: 20px;
            border-top: 1px solid var(--border-color);
            color: #6c757d;
        }
        
        .footer-links {
            display: flex;
            justify-content: center;
            gap: 20px;
            margin-top: 10px;
        }
        
        .footer-links a {
            color: var(--primary-color);
            text-decoration: none;
        }
        
        .footer-links a:hover {
            text-decoration: underline;
        }
        
        @media (max-width: 768px) {
            .form-row {
                flex-direction: column;
            }
            
            .form-col {
                width: 100%;
                margin-bottom: 15px;
            }
            
            .button-group {
                flex-direction: column;
                gap: 10px;
            }
            
            .btn {
                width: 100%;
            }
        }
    </style>
</head>
<body>
    <div class="container">
        <header>
            <h1>SISTEMA LIFE EVENTS</h1>
            <h2>CADASTRO DE CLIENTE</h2>
        </header>
        
        <form id="cadastroForm">
            <div class="form-section">
                <div class="section-title">Dados Pessoais</div>
                
                <div class="form-group">
                    <label for="nome">Nome Completo:</label>
                    <input type="text" id="nome" name="nome" required>
                </div>
                
                <div class="form-row">
                    <div class="form-col">
                        <label for="email">E-mail:</label>
                        <input type="email" id="email" name="email" required>
                    </div>
                    <div class="form-col">
                        <label for="telefone">Telefone:</label>
                        <input type="tel" id="telefone" name="telefone" placeholder="(00) 00000-0000" required>
                    </div>
                </div>
                
                <div class="form-row">
                    <div class="form-col">
                        <label for="cpf">CPF:</label>
                        <input type="text" id="cpf" name="cpf" placeholder="000.000.000-00" required>
                    </div>
                    <div class="form-col">
                        <label for="dataNascimento">Data de Nascimento:</label>
                        <input type="date" id="dataNascimento" name="dataNascimento" required>
                    </div>
                </div>
            </div>
            
            <div class="form-section">
                <div class="section-title">Endereço</div>
                
                <div class="form-group">
                    <label for="logradouro">Logradouro:</label>
                    <input type="text" id="logradouro" name="logradouro" required>
                </div>
                
                <div class="form-row">
                    <div class="form-col">
                        <label for="numero">Número:</label>
                        <input type="text" id="numero" name="numero" required>
                    </div>
                    <div class="form-col">
                        <label for="complemento">Complemento:</label>
                        <input type="text" id="complemento" name="complemento">
                    </div>
                </div>
                
                <div class="form-row">
                    <div class="form-col">
                        <label for="cep">CEP:</label>
                        <input type="text" id="cep" name="cep" placeholder="00000-000" required>
                    </div>
                    <div class="form-col">
                        <label for="cidade">Cidade:</label>
                        <input type="text" id="cidade" name="cidade" required>
                    </div>
                </div>
                
                <div class="form-group">
                    <label for="estado">Estado:</label>
                    <select id="estado" name="estado" required>
                        <option value="">Selecione</option>
                        <option value="SP" selected>São Paulo</option>
                        <option value="AC">Acre</option>
                        <option value="AL">Alagoas</option>
                        <option value="AP">Amapá</option>
                        <option value="AM">Amazonas</option>
                        <option value="BA">Bahia</option>
                        <option value="CE">Ceará</option>
                        <option value="DF">Distrito Federal</option>
                        <option value="ES">Espírito Santo</option>
                        <option value="GO">Goiás</option>
                        <option value="MA">Maranhão</option>
                        <option value="MT">Mato Grosso</option>
                        <option value="MS">Mato Grosso do Sul</option>
                        <option value="MG">Minas Gerais</option>
                        <option value="PA">Pará</option>
                        <option value="PB">Paraíba</option>
                        <option value="PR">Paraná</option>
                        <option value="PE">Pernambuco</option>
                        <option value="PI">Piauí</option>
                        <option value="RJ">Rio de Janeiro</option>
                        <option value="RN">Rio Grande do Norte</option>
                        <option value="RS">Rio Grande do Sul</option>
                        <option value="RO">Rondônia</option>
                        <option value="RR">Roraima</option>
                        <option value="SC">Santa Catarina</option>
                        <option value="SE">Sergipe</option>
                        <option value="TO">Tocantins</option>
                    </select>
                </div>
            </div>
            
            <div class="form-section">
                <div class="section-title">Informações do Evento</div>
                
                <div class="form-group">
                    <label>Tipo de Evento:</label>
                    <div class="radio-group">
                        <div class="radio-option">
                            <input type="radio" id="casamento" name="tipoEvento" value="casamento" checked>
                            <label for="casamento">Casamento</label>
                        </div>
                        <div class="radio-option">
                            <input type="radio" id="aniversario" name="tipoEvento" value="aniversario">
                            <label for="aniversario">Aniversário</label>
                        </div>
                        <div class="radio-option">
                            <input type="radio" id="corporativo" name="tipoEvento" value="corporativo">
                            <label for="corporativo">Corporativo</label>
                        </div>
                        <div class="radio-option">
                            <input type="radio" id="outro" name="tipoEvento" value="outro">
                            <label for="outro">Outro</label>
                        </div>
                    </div>
                </div>
                
                <div class="form-group">
                    <label for="observacoes">Observações:</label>
                    <textarea id="observacoes" name="observacoes" rows="4"></textarea>
                </div>
                
                <div class="form-group">
                    <label for="dataPrevisa">Data Prevista:</label>
                    <input type="date" id="dataPrevisa" name="dataPrevisa" required>
                </div>
            </div>
            
            <div class="form-section">
                <div class="section-title">Segurança</div>
                
                <div class="form-row">
                    <div class="form-col">
                        <label for="senha">Senha:</label>
                        <input type="password" id="senha" name="senha" required>
                    </div>
                    <div class="form-col">
                        <label for="confirmarSenha">Confirmar Senha:</label>
                        <input type="password" id="confirmarSenha" name="confirmarSenha" required>
                    </div>
                </div>
            </div>
            
            <div class="button-group">
                <button type="button" class="btn btn-cancel">CANCELAR</button>
                <button type="submit" class="btn btn-submit">CADASTRAR</button>
            </div>
        </form>
        
        <footer>
            <div class="footer-links">
                <a href="#">Política de Privacidade</a>
                <a href="#">Termos de Uso</a>
            </div>
        </footer>
    </div>

    <script>
        document.getElementById('cadastroForm').addEventListener('submit', function(e) {
            e.preventDefault();
            
            // Validação básica de senha
            const senha = document.getElementById('senha').value;
            const confirmarSenha = document.getElementById('confirmarSenha').value;
            
            if (senha !== confirmarSenha) {
                alert('As senhas não coincidem. Por favor, verifique.');
                return;
            }
            
            // Aqui você pode adicionar mais validações e enviar os dados
            alert('Cadastro realizado com sucesso!');
            // this.submit(); // Descomente para enviar o formulário
        });
        
        // Formatação automática para CPF
        document.getElementById('cpf').addEventListener('input', function(e) {
            let value = e.target.value.replace(/\D/g, '');
            if (value.length > 11) value = value.substring(0, 11);
            
            if (value.length > 9) {
                value = value.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
            } else if (value.length > 6) {
                value = value.replace(/(\d{3})(\d{3})(\d{1,3})/, '$1.$2.$3');
            } else if (value.length > 3) {
                value = value.replace(/(\d{3})(\d{1,3})/, '$1.$2');
            }
            
            e.target.value = value;
        });
        
        // Formatação automática para telefone
        document.getElementById('telefone').addEventListener('input', function(e) {
            let value = e.target.value.replace(/\D/g, '');
            if (value.length > 11) value = value.substring(0, 11);
            
            if (value.length > 10) {
                value = value.replace(/(\d{2})(\d{5})(\d{4})/, '($1) $2-$3');
            } else if (value.length > 6) {
                value = value.replace(/(\d{2})(\d{4})(\d{0,4})/, '($1) $2-$3');
            } else if (value.length > 2) {
                value = value.replace(/(\d{2})(\d{0,5})/, '($1) $2');
            } else if (value.length > 0) {
                value = value.replace(/(\d{0,2})/, '($1');
            }
            
            e.target.value = value;
        });
        
        // Formatação automática para CEP
        document.getElementById('cep').addEventListener('input', function(e) {
            let value = e.target.value.replace(/\D/g, '');
            if (value.length > 8) value = value.substring(0, 8);
            
            if (value.length > 5) {
                value = value.replace(/(\d{5})(\d{1,3})/, '$1-$2');
            }
            
            e.target.value = value;
        });
    </script>
</body>
</html>

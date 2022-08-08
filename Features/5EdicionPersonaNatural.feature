#Feature:Edicion Personal Natural
#
#Background: 
#	Given Usurio navega en el inicio de  External  sesion Chrome
#	And Cargo el  DOM de la app: Login
#	When Usuario se logea con credenciales OpheliaSuite y validPassword en los campos textUsername y textPassword
#	Then Espera de 5
#	And Click en el boton
#	Then Espera de 15
#    #Then User should be able to login succesfully Yuly Johana Aristizabal T
#
#@External
#Scenario Outline:5 Edicion Persona Natural 
#    Then Espera de 10
#	When Cargo el  DOM de la app: EscenarioPrincipal
#	Then Espera de 10
#    Then Clic en el BtnBandejaTarea
#	* Espera de 5
#	Then Clic en el BtnAbrirBandeja
#	* Espera de 10
#	Then Clic en el BtnIniciarProceso
#	* Espera de 8
#	Then en el campo TxtId ingreso 168016
#	* Espera de 8
#    * Clic en el BtnSeleccionarProceso
#	* Espera de 5
#	* Clic en el BtnIniciar
#	* Espera de 60
#	When Cambie al frame IdentificadorIframe
#	Then Espera de 5
#	Then en el campo NombreRemitente ingreso prueba
#    Then Espera de 5
#	When Cargo el  DOM de la app: CanalRecepcion
#	Then Espera de 5
#	Then Clic en el LupaCanalRecepcion
#	Then Espera de 5
#	Then Clic en el <CanalRecepcion>
#	Then Espera de 5
#	Then Clic en el BtnAceptarSelectCanalRecepcion
#	Then Espera de 5
#	When Cargo el  DOM de la app: TipoPersona
#	Then Espera de 5
#	Then Clic en el LupaTipoDePersona
#	Then Espera de 5
#	Then Clic en el PN
#	Then Espera de 5
#	Then Clic en el BtnAceptarTipoDePersona
#	Then Espera de 5
#	When Cargo el  DOM de la app: TipoIdentificacion
#	Then Espera de 5
#    Then Clic en el LupaIdentificacion
#	Then Espera de 5
#	Then Clic en el <TipoIdentificacion>
#	Then Espera de 5
#	Then Clic en el BtnAceptarTipoIdentificacion
#	Then Espera de 10
#    And Toma pantallazo
#	When Cargo el  DOM de la app: EscenarioPrincipal
#	Then Espera de 5
#	Then Clic en el BtnDatoDocumento
#	Then Espera de 5
#	When subo el archivo BtnSeleccionarArchivo en en el campo C:\Users\yulia\Documents\Procesosgdeatest\Datos\Elemento 10027 2022-04-11 13-37-51.zip
#	Then Espera de 5
#	And Toma pantallazo
#	Then Espera de 5
#	Then Clic en el BtnDatosTramite
#	Then Espera de 5
#	When Cargo el  DOM de la app: DependenciaDestino
#	Then Espera de 5
#	Then Clic en el LupaDependenciaDestino
#	Then Espera de 5
#	Then Clic en el <DependenciaDestino>
#	Then Espera de 5
#	Then Clic en el BtnDependenciaDestino
#	Then Espera de 5
#	When Cargo el  DOM de la app: FuncionarioResponsable
#	Then Espera de 5
#	Then Clic en el LupaFuncionarioResponsable
#	Then Espera de 5
#	Then Clic en el <FuncionarioResponsable>
#	Then Espera de 5
#	Then Clic en el BtnAceptarFuncionarioResponsable
#	Then Espera de 10
#	And Toma pantallazo
#	When Cargo el  DOM de la app: EscenarioPrincipal
#	Then Espera de 5
#	When realizo Scroll PQRSD
#	Then Espera de 5
#	When Cargo el  DOM de la app: TipoPQRSD
#	Then Clic en el LupaTipoPQRSD
#	Then Espera de 5
#	Then Clic en el <TipoPQRSD>
#	Then Espera de 5
#	Then Clic en el BtnAceptarTipoPQRSD
#	Then Espera de 5
#	When Cargo el  DOM de la app: EscenarioPrincipal
#	Then Espera de 5
#	Then en el campo Asunto ingreso Prueba
#	Then Espera de 5
#	Then Clic en el Radicado
#	Then Espera de 5
#	Then Clic en el SelectRadicado
#	Then Espera de 5
#	Then Clic en el BtnTipoPQRSD
#	Then Espera de 5
#	When salir del iframe
#	Then Espera de 5
#	And Toma pantallazo
#	Then Clic en el Informacion
#	Then Espera de 5
#	Then Clic en el Copiar
#	Then Espera de 5
#	Then Clic en el Aceptar
#	Then Espera de 5
#	Then DobleClic ConcluirTarea
#	Then Espera de 15
#	Then Clic en el BtnTrazabilidadProcesos
#	Then Espera de 5
#	When pegar referencia del caso TxtReferencia
#	Then Espera de 5
#	Then Clic en el BtnLupa
#	Then Espera de 5
#	And Toma pantallazo
#	Then DobleClic SelectProceso1
#	Then Espera de 5
#	And Toma pantallazo
#	Then Espera de 5
#	Then Clic en el BtnBandejaTareas
#	Then Espera de 10
#	Then Clic en el BtnRecargasTareas
#	Then Espera de 10
#	And Toma pantallazo
#	When pegar referencia del caso TxtReferencia2
#	Then Espera de 10
#	Then Clic en el BtnAbrirTarea
#	Then Espera de 10
#	When Cambie al frame IdentificadorIframe3
#	Then Espera de 5
#	When validacion inconsistencias Validacion
#	Then Espera de 10
#	Then Espera de 5
#	Then Clic en el BtnSiEdicion
#	Then Espera de 5
#	Then Clic en el BtnAjusteRadicacionPQRSD
#	Then Espera de 5
#	When Cargo el  DOM de la app: CanalRecepcion
#	Then Espera de 5
#	Then Clic en el Btnx
#	When Cargo el  DOM de la app: TipoPersona
#	Then Espera de 5
#	Then Clic en el Btnx2
#	Then Espera de 15
#	When Cargo el  DOM de la app: EscenarioPrincipal
#	Then Espera de 5
#	When Cargo el  DOM de la app: CanalRecepcion
#	Then Espera de 5
#	Then Clic en el LupaCanalRecepcion2
#	Then Espera de 5
#	Then Clic en el <CanalRecepcion>
#	Then Espera de 5
#	Then Clic en el BtnAceptarSelectCanalRecepcion
#	Then Espera de 5
#	When Cargo el  DOM de la app: TipoPersona
#	Then Espera de 5
#	Then Clic en el LupaTipoDePersona2
#	Then Espera de 5
#	Then Clic en el PA
#	Then Espera de 5
#	Then Clic en el BtnAceptarTipoDePersona
#	Then Espera de 5
#	When Cargo el  DOM de la app: EscenarioPrincipal
#	Then Espera de 5
#	When salir del iframe
#	Then Espera de 5
#	Then DobleClic ConcluirTarea2
#	Then Espera de 10
#	Then Clic en el BtnBPM
#	Then Espera de 5
#	Then Clic en el BtnRefrescar
#	Then Espera de 5
#	Then Clic en el BtnBandejaTareas
#	Then Espera de 5
#	Then Clic en el BtnRecargasTareas
#	Then Espera de 10
#	Then Clic en el BtnAbrirTarea
#	Then Espera de 10
#	When Cambie al frame IdentificadorIframe4
#	Then Espera de 5
#	When validacion inconsistencias Validacion
#	Then Espera de 10
#	When salir del iframe
#	Then DobleClic BtnConcluirTarea3
#	Then Espera de 10
#	Then Clic en el BtnBPM
#	Then Espera de 5
#	Then Clic en el BtnRefrescar
#	Then Espera de 5
#	And Toma pantallazo
#	Then Espera de 5
#	Then Clic en el BtnPerfil
#	Then Espera de 5
#	Then Clic en el BtnCerrarSesion
#	Then Espera de 5
#	Then Clic en el BtnSi
#	Then Espera de 10
#
#Examples: 
#| CanalRecepcion | DependenciaDestino | FuncionarioResponsable | TipoPQRSD | TipoIdentificacion |
#| Chat           | 1                  | 1                      | Den       | CC                |
#| Red            | 2                  | 2                      | Pet       | CE                |
#| Mail           | 3                  | 3                      | Que       | ND                |
#| PorWeb         | 4                  | 4                      | Rec       | PA                |
#| Fax            | 5                  | 5                      | Sol       | RC               |
#| Lla_Tel        | 6                  | 6                      | Sug       | TI               |
#| Vent           | 7                  | 7                      | Den       | CC                |
#| Verb           | 8                  | 8                      | Pet       | CE                |
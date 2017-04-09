@Code
    ViewData("Title") = "Registro_Usuarios"
End Code


    <div class="container-fluid">
        <hr>
        <div class="row-fluid">
            <div class="span6">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"> <i class="icon-align-justify"></i> </span>
                        <h5>Datos Personales</h5>
                    </div>
                    <div class="widget-content nopadding">
                        <form action="#" method="get" class="form-horizontal">
                            <div class="control-group">
                                <label class="control-label">Nombre:</label>
                                <div class="controls">
                                    <input type="text" class="span11" placeholder="Nombre" />
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label">Apellidos:</label>
                                <div class="controls">
                                    <input type="text" class="span11" placeholder="Apellidos" />
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label">Contraseña:</label>
                                <div class="controls">
                                    <input type="password" class="span11" placeholder="Contraseña" />
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label">Confirmar Contraseña:</label>
                                <div class="controls">
                                    <input type="password" class="span11" placeholder="Confirmar Contraseña" />
                                </div>
                            </div>
                         
                            <div class="control-group">
                                <label for="normal" class="control-label">Teléfono:</label>
                                <div class="controls">
                                    <input type="text" id="mask-phone" class="span8 mask text" placeholder="Teléfono">
                                </div>
                            </div>

                            <div class="control-group">
                                <label for="normal" class="control-label">Correo:</label>
                                <div class="controls">
                                    <input type="text" id="mask-phone" class="span8 mask text" placeholder="Correo">
                                </div>
                            </div>

                            <div class="control-group">
                                <label class="control-label">Tipo de Usuario</label>
                                <div class="controls">
                                    <select>
                                        <option>Administrador</option>
                                        <option>Taller</option>
                                        <option>Cliente</option>
                                    </select>
                                </div>
                            </div>


                            <div class="form-actions">
                                <button type="submit" class="btn btn-success">Guardar</button>
                            </div>
                        </form>
                    </div>
                </div>
               
            </div>
       
        </div>

        <div class="widget-box">
            <div class="widget-title">
                <span class="icon"> <i class="icon-th"></i> </span>
                <h5>Lista de Usuarios</h5>
            </div>
            <div class="widget-content nopadding">
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nombre</th>
                            <th>Tipo</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Marlon Rojas Mendez</td>
                            <td>Administrador</td>
                            <td><a class="tip" href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Eilyn Salazar Badilla</td>
                            <td>Administradora</td>
                            <td><a class="tip" href="#" title="Editar"><i class="icon-pencil"></i></a> <a class="tip" href="#" title="Eliminar"><i class="icon-remove"></i></a></td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
     
    </div>

@*<script>
	$('.textarea_editor').wysihtml5();
</script>*@

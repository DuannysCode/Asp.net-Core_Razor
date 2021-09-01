// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var hide = false;
function toggleTable()
{
    if (hide == false)
    {
        hide = true;
        document.getElementById('tabla_amortizacion').style.display = 'none';
    }
}

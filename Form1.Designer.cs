using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections.Generic;

namespace Fragmentacion_horizontal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        -- Crear las tablas fragmentadas
CREATE TABLE roysched_frag1(
    title_id CHAR(6) NOT NULL,
    lorange INT NULL,
    hirange INT NULL,
    royalty INT NULL,
    
);

        CREATE TABLE roysched_frag2(
            title_id CHAR(6) NOT NULL,
            lorange INT NULL,
            hirange INT NULL,
            royalty INT NULL,
           
);

-- Fragmentar los datos(Ejemplo de fragmentación por título)
INSERT INTO roysched_frag1
SELECT* FROM roysched WHERE title_id IN('BU1032', 'BU2075', 'BU1111', 'BU7832');

        INSERT INTO roysched_frag2
SELECT* FROM roysched WHERE title_id NOT IN('BU1032', 'BU2075', 'BU1111', 'BU7832');

-- Verificar los resultados
SELECT* FROM roysched_frag1;
SELECT* FROM roysched_frag2;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

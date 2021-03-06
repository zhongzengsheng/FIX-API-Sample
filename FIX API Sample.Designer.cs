﻿namespace FIX_API_Sample
{
    partial class frmFIXAPISample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogonP = new System.Windows.Forms.Button();
            this.btnTestRequestP = new System.Windows.Forms.Button();
            this.lblHeartbeatMessage = new System.Windows.Forms.Label();
            this.btnLogoutP = new System.Windows.Forms.Button();
            this.btnDepthMarketDataRequest = new System.Windows.Forms.Button();
            this.txtMessageSend = new System.Windows.Forms.TextBox();
            this.lblMessageSend = new System.Windows.Forms.Label();
            this.lblMessageReceived = new System.Windows.Forms.Label();
            this.txtMessageReceived = new System.Windows.Forms.TextBox();
            this.btnHeartbeatP = new System.Windows.Forms.Button();
            this.btnResendRequestP = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnSequenceReset = new System.Windows.Forms.Button();
            this.btnNewOrderSingle = new System.Windows.Forms.Button();
            this.btnOrderStatusRequest = new System.Windows.Forms.Button();
            this.btnRequestForPositions = new System.Windows.Forms.Button();
            this.gbPriceStream = new System.Windows.Forms.GroupBox();
            this.btnSpotMarketData = new System.Windows.Forms.Button();
            this.gbTradeStream = new System.Windows.Forms.GroupBox();
            this.btnResendRequestT = new System.Windows.Forms.Button();
            this.btnLogoutT = new System.Windows.Forms.Button();
            this.btnLogonT = new System.Windows.Forms.Button();
            this.btnHeartbeatT = new System.Windows.Forms.Button();
            this.btnTestRequestT = new System.Windows.Forms.Button();
            this.btnLimitOrder = new System.Windows.Forms.Button();
            this.btnStopOrder = new System.Windows.Forms.Button();
            this.gbPriceStream.SuspendLayout();
            this.gbTradeStream.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogonP
            // 
            this.btnLogonP.Location = new System.Drawing.Point(6, 19);
            this.btnLogonP.Name = "btnLogonP";
            this.btnLogonP.Size = new System.Drawing.Size(160, 23);
            this.btnLogonP.TabIndex = 0;
            this.btnLogonP.Text = "Logon";
            this.btnLogonP.UseVisualStyleBackColor = true;
            this.btnLogonP.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // btnTestRequestP
            // 
            this.btnTestRequestP.Location = new System.Drawing.Point(6, 77);
            this.btnTestRequestP.Name = "btnTestRequestP";
            this.btnTestRequestP.Size = new System.Drawing.Size(160, 23);
            this.btnTestRequestP.TabIndex = 2;
            this.btnTestRequestP.Text = "Send Test Request";
            this.btnTestRequestP.UseVisualStyleBackColor = true;
            this.btnTestRequestP.Click += new System.EventHandler(this.btnTestRequest_Click);
            // 
            // lblHeartbeatMessage
            // 
            this.lblHeartbeatMessage.AutoSize = true;
            this.lblHeartbeatMessage.Location = new System.Drawing.Point(12, 33);
            this.lblHeartbeatMessage.Name = "lblHeartbeatMessage";
            this.lblHeartbeatMessage.Size = new System.Drawing.Size(0, 13);
            this.lblHeartbeatMessage.TabIndex = 3;
            // 
            // btnLogoutP
            // 
            this.btnLogoutP.Location = new System.Drawing.Point(6, 251);
            this.btnLogoutP.Name = "btnLogoutP";
            this.btnLogoutP.Size = new System.Drawing.Size(160, 23);
            this.btnLogoutP.TabIndex = 4;
            this.btnLogoutP.Text = "Logout";
            this.btnLogoutP.UseVisualStyleBackColor = true;
            this.btnLogoutP.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDepthMarketDataRequest
            // 
            this.btnDepthMarketDataRequest.Location = new System.Drawing.Point(6, 135);
            this.btnDepthMarketDataRequest.Name = "btnDepthMarketDataRequest";
            this.btnDepthMarketDataRequest.Size = new System.Drawing.Size(160, 23);
            this.btnDepthMarketDataRequest.TabIndex = 5;
            this.btnDepthMarketDataRequest.TabStop = false;
            this.btnDepthMarketDataRequest.Text = "Depth Market Data Request";
            this.btnDepthMarketDataRequest.UseVisualStyleBackColor = true;
            this.btnDepthMarketDataRequest.Click += new System.EventHandler(this.btnMarketDataRequest_Click);
            // 
            // txtMessageSend
            // 
            this.txtMessageSend.Location = new System.Drawing.Point(145, 331);
            this.txtMessageSend.Name = "txtMessageSend";
            this.txtMessageSend.Size = new System.Drawing.Size(711, 20);
            this.txtMessageSend.TabIndex = 6;
            // 
            // lblMessageSend
            // 
            this.lblMessageSend.AutoSize = true;
            this.lblMessageSend.Location = new System.Drawing.Point(18, 334);
            this.lblMessageSend.Name = "lblMessageSend";
            this.lblMessageSend.Size = new System.Drawing.Size(100, 13);
            this.lblMessageSend.TabIndex = 7;
            this.lblMessageSend.Text = "FIX Message Send:";
            // 
            // lblMessageReceived
            // 
            this.lblMessageReceived.AutoSize = true;
            this.lblMessageReceived.Location = new System.Drawing.Point(18, 361);
            this.lblMessageReceived.Name = "lblMessageReceived";
            this.lblMessageReceived.Size = new System.Drawing.Size(121, 13);
            this.lblMessageReceived.TabIndex = 9;
            this.lblMessageReceived.Text = "FIX Message Received:";
            // 
            // txtMessageReceived
            // 
            this.txtMessageReceived.Location = new System.Drawing.Point(145, 358);
            this.txtMessageReceived.Name = "txtMessageReceived";
            this.txtMessageReceived.Size = new System.Drawing.Size(711, 20);
            this.txtMessageReceived.TabIndex = 8;
            // 
            // btnHeartbeatP
            // 
            this.btnHeartbeatP.Location = new System.Drawing.Point(6, 48);
            this.btnHeartbeatP.Name = "btnHeartbeatP";
            this.btnHeartbeatP.Size = new System.Drawing.Size(160, 23);
            this.btnHeartbeatP.TabIndex = 10;
            this.btnHeartbeatP.Text = "Send Heartbeat";
            this.btnHeartbeatP.UseVisualStyleBackColor = true;
            this.btnHeartbeatP.Click += new System.EventHandler(this.btnHeartbeat_Click);
            // 
            // btnResendRequestP
            // 
            this.btnResendRequestP.Location = new System.Drawing.Point(6, 164);
            this.btnResendRequestP.Name = "btnResendRequestP";
            this.btnResendRequestP.Size = new System.Drawing.Size(160, 23);
            this.btnResendRequestP.TabIndex = 11;
            this.btnResendRequestP.Text = "Resend Request";
            this.btnResendRequestP.UseVisualStyleBackColor = true;
            this.btnResendRequestP.Click += new System.EventHandler(this.btnResendRequest_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(6, 222);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(160, 23);
            this.btnReject.TabIndex = 12;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnSequenceReset
            // 
            this.btnSequenceReset.Location = new System.Drawing.Point(6, 193);
            this.btnSequenceReset.Name = "btnSequenceReset";
            this.btnSequenceReset.Size = new System.Drawing.Size(160, 23);
            this.btnSequenceReset.TabIndex = 13;
            this.btnSequenceReset.Text = "Sequence Reset";
            this.btnSequenceReset.UseVisualStyleBackColor = true;
            this.btnSequenceReset.Click += new System.EventHandler(this.btnSequenceReset_Click);
            // 
            // btnNewOrderSingle
            // 
            this.btnNewOrderSingle.Location = new System.Drawing.Point(6, 106);
            this.btnNewOrderSingle.Name = "btnNewOrderSingle";
            this.btnNewOrderSingle.Size = new System.Drawing.Size(160, 23);
            this.btnNewOrderSingle.TabIndex = 14;
            this.btnNewOrderSingle.Text = "New Market Order Single";
            this.btnNewOrderSingle.UseVisualStyleBackColor = true;
            this.btnNewOrderSingle.Click += new System.EventHandler(this.btnNewOrderSingle_Click);
            // 
            // btnOrderStatusRequest
            // 
            this.btnOrderStatusRequest.Location = new System.Drawing.Point(6, 193);
            this.btnOrderStatusRequest.Name = "btnOrderStatusRequest";
            this.btnOrderStatusRequest.Size = new System.Drawing.Size(160, 23);
            this.btnOrderStatusRequest.TabIndex = 15;
            this.btnOrderStatusRequest.Text = "Order Status Request";
            this.btnOrderStatusRequest.UseVisualStyleBackColor = true;
            this.btnOrderStatusRequest.Click += new System.EventHandler(this.btnOrderStatusRequest_Click);
            // 
            // btnRequestForPositions
            // 
            this.btnRequestForPositions.Location = new System.Drawing.Point(6, 222);
            this.btnRequestForPositions.Name = "btnRequestForPositions";
            this.btnRequestForPositions.Size = new System.Drawing.Size(160, 23);
            this.btnRequestForPositions.TabIndex = 16;
            this.btnRequestForPositions.Text = "Request for Positions";
            this.btnRequestForPositions.UseVisualStyleBackColor = true;
            this.btnRequestForPositions.Click += new System.EventHandler(this.btnRequestForPositions_Click);
            // 
            // gbPriceStream
            // 
            this.gbPriceStream.Controls.Add(this.btnSpotMarketData);
            this.gbPriceStream.Controls.Add(this.btnLogonP);
            this.gbPriceStream.Controls.Add(this.btnHeartbeatP);
            this.gbPriceStream.Controls.Add(this.btnTestRequestP);
            this.gbPriceStream.Controls.Add(this.btnLogoutP);
            this.gbPriceStream.Controls.Add(this.btnReject);
            this.gbPriceStream.Controls.Add(this.btnSequenceReset);
            this.gbPriceStream.Controls.Add(this.btnDepthMarketDataRequest);
            this.gbPriceStream.Controls.Add(this.btnResendRequestP);
            this.gbPriceStream.Location = new System.Drawing.Point(15, 14);
            this.gbPriceStream.Name = "gbPriceStream";
            this.gbPriceStream.Size = new System.Drawing.Size(181, 293);
            this.gbPriceStream.TabIndex = 17;
            this.gbPriceStream.TabStop = false;
            this.gbPriceStream.Text = "Price Stream";
            // 
            // btnSpotMarketData
            // 
            this.btnSpotMarketData.Location = new System.Drawing.Point(6, 106);
            this.btnSpotMarketData.Name = "btnSpotMarketData";
            this.btnSpotMarketData.Size = new System.Drawing.Size(160, 23);
            this.btnSpotMarketData.TabIndex = 14;
            this.btnSpotMarketData.Text = "Spot Market Data Request";
            this.btnSpotMarketData.UseVisualStyleBackColor = true;
            this.btnSpotMarketData.Click += new System.EventHandler(this.btnSpotMarketData_Click);
            // 
            // gbTradeStream
            // 
            this.gbTradeStream.Controls.Add(this.btnStopOrder);
            this.gbTradeStream.Controls.Add(this.btnLimitOrder);
            this.gbTradeStream.Controls.Add(this.btnResendRequestT);
            this.gbTradeStream.Controls.Add(this.btnLogoutT);
            this.gbTradeStream.Controls.Add(this.btnLogonT);
            this.gbTradeStream.Controls.Add(this.btnHeartbeatT);
            this.gbTradeStream.Controls.Add(this.btnRequestForPositions);
            this.gbTradeStream.Controls.Add(this.btnTestRequestT);
            this.gbTradeStream.Controls.Add(this.btnOrderStatusRequest);
            this.gbTradeStream.Controls.Add(this.btnNewOrderSingle);
            this.gbTradeStream.Location = new System.Drawing.Point(202, 14);
            this.gbTradeStream.Name = "gbTradeStream";
            this.gbTradeStream.Size = new System.Drawing.Size(176, 311);
            this.gbTradeStream.TabIndex = 18;
            this.gbTradeStream.TabStop = false;
            this.gbTradeStream.Text = "Trade Stream";
            // 
            // btnResendRequestT
            // 
            this.btnResendRequestT.Location = new System.Drawing.Point(6, 251);
            this.btnResendRequestT.Name = "btnResendRequestT";
            this.btnResendRequestT.Size = new System.Drawing.Size(160, 23);
            this.btnResendRequestT.TabIndex = 14;
            this.btnResendRequestT.Text = "Resend Request";
            this.btnResendRequestT.UseVisualStyleBackColor = true;
            this.btnResendRequestT.Click += new System.EventHandler(this.btnResendRequestT_Click);
            // 
            // btnLogoutT
            // 
            this.btnLogoutT.Location = new System.Drawing.Point(6, 280);
            this.btnLogoutT.Name = "btnLogoutT";
            this.btnLogoutT.Size = new System.Drawing.Size(160, 23);
            this.btnLogoutT.TabIndex = 17;
            this.btnLogoutT.Text = "Logout";
            this.btnLogoutT.UseVisualStyleBackColor = true;
            this.btnLogoutT.Click += new System.EventHandler(this.btnLogoutT_Click);
            // 
            // btnLogonT
            // 
            this.btnLogonT.Location = new System.Drawing.Point(6, 19);
            this.btnLogonT.Name = "btnLogonT";
            this.btnLogonT.Size = new System.Drawing.Size(160, 23);
            this.btnLogonT.TabIndex = 14;
            this.btnLogonT.Text = "Logon";
            this.btnLogonT.UseVisualStyleBackColor = true;
            this.btnLogonT.Click += new System.EventHandler(this.btnLogonT_Click);
            // 
            // btnHeartbeatT
            // 
            this.btnHeartbeatT.Location = new System.Drawing.Point(6, 48);
            this.btnHeartbeatT.Name = "btnHeartbeatT";
            this.btnHeartbeatT.Size = new System.Drawing.Size(160, 23);
            this.btnHeartbeatT.TabIndex = 16;
            this.btnHeartbeatT.Text = "Send Heartbeat";
            this.btnHeartbeatT.UseVisualStyleBackColor = true;
            this.btnHeartbeatT.Click += new System.EventHandler(this.btnHeartbeatT_Click);
            // 
            // btnTestRequestT
            // 
            this.btnTestRequestT.Location = new System.Drawing.Point(6, 77);
            this.btnTestRequestT.Name = "btnTestRequestT";
            this.btnTestRequestT.Size = new System.Drawing.Size(160, 23);
            this.btnTestRequestT.TabIndex = 15;
            this.btnTestRequestT.Text = "Send Test Request";
            this.btnTestRequestT.UseVisualStyleBackColor = true;
            this.btnTestRequestT.Click += new System.EventHandler(this.btnTestRequestT_Click);
            // 
            // btnLimitOrder
            // 
            this.btnLimitOrder.Location = new System.Drawing.Point(6, 135);
            this.btnLimitOrder.Name = "btnLimitOrder";
            this.btnLimitOrder.Size = new System.Drawing.Size(160, 23);
            this.btnLimitOrder.TabIndex = 18;
            this.btnLimitOrder.Text = "New Limit Order Single";
            this.btnLimitOrder.UseVisualStyleBackColor = true;
            this.btnLimitOrder.Click += new System.EventHandler(this.btnLimitOrder_Click);
            // 
            // btnStopOrder
            // 
            this.btnStopOrder.Location = new System.Drawing.Point(6, 164);
            this.btnStopOrder.Name = "btnStopOrder";
            this.btnStopOrder.Size = new System.Drawing.Size(160, 23);
            this.btnStopOrder.TabIndex = 19;
            this.btnStopOrder.Text = "New Stop Order Single";
            this.btnStopOrder.UseVisualStyleBackColor = true;
            this.btnStopOrder.Click += new System.EventHandler(this.btnStopOrder_Click);
            // 
            // frmFIXAPISample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 388);
            this.Controls.Add(this.gbTradeStream);
            this.Controls.Add(this.gbPriceStream);
            this.Controls.Add(this.lblMessageReceived);
            this.Controls.Add(this.txtMessageReceived);
            this.Controls.Add(this.lblMessageSend);
            this.Controls.Add(this.txtMessageSend);
            this.Controls.Add(this.lblHeartbeatMessage);
            this.Name = "frmFIXAPISample";
            this.ShowIcon = false;
            this.Text = "Fix API Sample";
            this.gbPriceStream.ResumeLayout(false);
            this.gbTradeStream.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogonP;
        private System.Windows.Forms.Button btnTestRequestP;
        private System.Windows.Forms.Label lblHeartbeatMessage;
        private System.Windows.Forms.Button btnLogoutP;
        private System.Windows.Forms.Button btnDepthMarketDataRequest;
        private System.Windows.Forms.TextBox txtMessageSend;
        private System.Windows.Forms.Label lblMessageSend;
        private System.Windows.Forms.Label lblMessageReceived;
        private System.Windows.Forms.TextBox txtMessageReceived;
        private System.Windows.Forms.Button btnHeartbeatP;
        private System.Windows.Forms.Button btnResendRequestP;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnSequenceReset;
        private System.Windows.Forms.Button btnNewOrderSingle;
        private System.Windows.Forms.Button btnOrderStatusRequest;
        private System.Windows.Forms.Button btnRequestForPositions;
        private System.Windows.Forms.GroupBox gbPriceStream;
        private System.Windows.Forms.GroupBox gbTradeStream;
        private System.Windows.Forms.Button btnLogoutT;
        private System.Windows.Forms.Button btnLogonT;
        private System.Windows.Forms.Button btnHeartbeatT;
        private System.Windows.Forms.Button btnTestRequestT;
        private System.Windows.Forms.Button btnResendRequestT;
        private System.Windows.Forms.Button btnSpotMarketData;
        private System.Windows.Forms.Button btnStopOrder;
        private System.Windows.Forms.Button btnLimitOrder;
    }
}


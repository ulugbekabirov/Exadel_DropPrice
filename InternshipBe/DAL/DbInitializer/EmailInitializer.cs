﻿using DAL.DataContext;
using DAL.Entities;
using Shared.Infrastructure;
using System.Linq;

namespace DAL.DbInitializer
{
    class EmailsInitializer
    {
        private readonly ApplicationDbContext _context;

        public EmailsInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmailTemplate(string name, string value, string discription)
        {
            if (!_context.ConfigVariables.Any(p => p.Name == name))
            {
                _context.ConfigVariables.Add(new ConfigVariable()
                {
                    Name = name,
                    Value = value,
                    Description = discription,
                    DataType = DataTypes.String,
                });

                _context.SaveChanges();
            }
        }

        public void InitializeEmails()
        {
            AddEmailTemplate("EnMessageForUser", @"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
<html xmlns='http://www.w3.org/1999/xhtml' xmlns:o='urn:schemas-microsoft-com:office:office' style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
<head>
    <meta content='width=device-width, initial-scale=1' name='viewport'>
    <meta charset='UTF-8'>
    <meta name='x-apple-disable-message-reformatting'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta content='telephone=no' name='format-detection'>
    <title>пиьсьмо юзеру англ</title> <!--[if (mso 16)]><style type='text/css'>     a {text-decoration: none;}     </style><![endif]--> <!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--> <!--[if gte mso 9]><xml> <o:OfficeDocumentSettings> <o:AllowPNG></o:AllowPNG> <o:PixelsPerInch>96</o:PixelsPerInch> </o:OfficeDocumentSettings> </xml><![endif]--> <!--[if !mso]><!-- -->
    <link href='https://fonts.googleapis.com/css?family=helvetica:400,400i,700,700i' rel='stylesheet'> <!--<![endif]-->
    <style type='text/css'>
        a {
            font-family: helvetica, courier,   serif;
            font-size: 16px;
            text-decoration: underline;
        }

        #outlook a {
            padding: 0;
        }

        .ExternalClass {
            width: 100%;
        }

            .ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {
                line-height: 100%;
            }

        .es-button {
            mso-style-priority: 100 !important;
            text-decoration: none !important;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
            font-size: inherit !important;
            font-family: inherit !important;
            font-weight: inherit !important;
            line-height: inherit !important;
        }

        .es-desk-hidden {
            display: none;
            float: left;
            overflow: hidden;
            width: 0;
            max-height: 0;
            line-height: 0;
            mso-hide: all;
        }

        @media only screen and (max-width:600px) {
            p, ul li, ol li, a {
                font-size: 16px !important;
                line-height: 150% !important
            }

            h1 {
                font-size: 30px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 18px
            }

            h2 {
                font-size: 26px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 16px
            }

            h3 {
                font-size: 20px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 12px
            }

            h1 a {
                font-size: 30px !important
            }

            h2 a {
                font-size: 26px !important
            }

            h3 a {
                font-size: 20px !important
            }

            .es-menu td a {
                font-size: 16px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a {
                font-size: 16px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a {
                font-size: 16px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a {
                font-size: 16px !important
            }

            *[class='gmail-fix'] {
                display: none !important
            }

            .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 {
                text-align: center !important
            }

            .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 {
                text-align: right !important
            }

            .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 {
                text-align: left !important
            }

                .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img {
                    display: inline !important
                }

            .es-button-border {
                display: block !important
            }

            .es-btn-fw {
                border-width: 10px 0px !important;
                text-align: center !important
            }

            .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right {
                width: 100% !important
            }

            .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header {
                width: 100% !important;
                max-width: 600px !important
            }

            .es-adapt-td {
                display: block !important;
                width: 100% !important
            }

            .adapt-img {
                width: 100% !important;
                height: auto !important
            }

            .es-m-p0 {
                padding: 0px !important
            }

            .es-m-p0r {
                padding-right: 0px !important
            }

            .es-m-p0l {
                padding-left: 0px !important
            }

            .es-m-p0t {
                padding-top: 0px !important
            }

            .es-m-p0b {
                padding-bottom: 0 !important
            }

            .es-m-p20b {
                padding-bottom: 20px !important
            }

            .es-mobile-hidden, .es-hidden {
                display: none !important
            }

            tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden {
                width: auto !important;
                overflow: visible !important;
                float: none !important;
                max-height: inherit !important;
                line-height: inherit !important
            }

            tr.es-desk-hidden {
                display: table-row !important
            }

            table.es-desk-hidden {
                display: table !important
            }

            td.es-desk-menu-hidden {
                display: table-cell !important
            }

            .es-menu td {
                width: 1% !important
            }

            table.es-table-not-adapt, .esd-block-html table {
                width: auto !important
            }

            table.es-social {
                display: inline-block !important
            }

                table.es-social td {
                    display: inline-block !important
                }

            a.es-button, button.es-button {
                font-size: 20px !important;
                display: block !important;
                border-left-width: 0px !important;
                border-right-width: 0px !important
            }

            .es-m-margin {
                padding-left: 10px !important;
                padding-right: 10px !important;
                padding-top: 10px !important;
                padding-bottom: 10px !important
            }

            p, ul li, ol li {
                margin-bottom: 12px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li {
                margin-bottom: 12px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li {
                margin-bottom: 12px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li {
                margin-bottom: 12px !important
            }
        }
    </style>
</head>
<body style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
    <div class='es-wrapper-color' style='background-color:#F6F6F6'>
        <!--[if gte mso 9]><v:background xmlns:v='urn:schemas-microsoft-com:vml' fill='t'> <v:fill type='tile' color='#f6f6f6'></v:fill> </v:background><![endif]--><table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'>
            <tr style='border-collapse:collapse'>
                <td class='es-m-margin' valign='top' style='padding:0;Margin:0'>
                    <table cellpadding='0' cellspacing='0' class='es-content' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%'>
                        <tr style='border-collapse:collapse'>
                            <td align='center' style='padding:0;Margin:0'>
                                <table class='es-content-body' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px' cellspacing='0' cellpadding='0' align='center' bgcolor='#FFFFFF'>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0;font-size:0px'><img src='https://naqgik.stripocdn.email/content/guids/CABINET_034eaea83c8d1d71346c232bbb2726eb/images/35461613885865928.png' alt style='display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' width='180'></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='center' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:24px;font-family:helvetica, courier,   serif;line-height:36px;margin-bottom:12px;color:#333333'>Ticket for user</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>FirstName:</b>&nbsp;##FirstName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>LastName:</b>&nbsp;##LastName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Patronymic:</b>&nbsp;##Patronymic##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Vendor:</b>&nbsp;##Vendor##<br></p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Product/Service:</b>##DiscountName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Email:</b>&nbsp;##VendorEmail##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Phone:</b>&nbsp;##VendorPhone##</p></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b>Discount:</b>&nbsp;<span style='color: #990000;'> ##DiscountValue## %</span></h2></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b><span style='color: #990000;'>##Promocode##</span></b></h2>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'>Confirmation: ##Date##</p></td></tr></table></td></tr></table></td></tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
", "Email template for user in english. Words like ##Word## are replaced with values from the database.");
            AddEmailTemplate("EnMessageForVendor", @"
<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
<html xmlns='http://www.w3.org/1999/xhtml' xmlns:o='urn:schemas-microsoft-com:office:office' style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
<head>
    <meta content='width=device-width, initial-scale=1' name='viewport'>
    <meta charset='UTF-8'>
    <meta name='x-apple-disable-message-reformatting'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta content='telephone=no' name='format-detection'>
    <title>пиьсьмо юзеру англ</title> <!--[if (mso 16)]><style type='text/css'>     a {text-decoration: none;}     </style><![endif]--> <!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--> <!--[if gte mso 9]><xml> <o:OfficeDocumentSettings> <o:AllowPNG></o:AllowPNG> <o:PixelsPerInch>96</o:PixelsPerInch> </o:OfficeDocumentSettings> </xml><![endif]--> <!--[if !mso]><!-- -->
    <link href='https://fonts.googleapis.com/css?family=helvetica:400,400i,700,700i' rel='stylesheet'> <!--<![endif]-->
    <style type='text/css'>
        a {
            font-family: helvetica, courier, serif;
            font-size: 16px;
            text-decoration: underline;
        }

        #outlook a {
            padding: 0;
        }

        .ExternalClass {
            width: 100%;
        }

            .ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {
                line-height: 100%;
            }

        .es-button {
            mso-style-priority: 100 !important;
            text-decoration: none !important;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
            font-size: inherit !important;
            font-family: inherit !important;
            font-weight: inherit !important;
            line-height: inherit !important;
        }

        .es-desk-hidden {
            display: none;
            float: left;
            overflow: hidden;
            width: 0;
            max-height: 0;
            line-height: 0;
            mso-hide: all;
        }

        @media only screen and (max-width:600px) {
            p, ul li, ol li, a {
                font-size: 16px !important;
                line-height: 150% !important
            }

            h1 {
                font-size: 30px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 18px
            }

            h2 {
                font-size: 26px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 16px
            }

            h3 {
                font-size: 20px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 12px
            }

            h1 a {
                font-size: 30px !important
            }

            h2 a {
                font-size: 26px !important
            }

            h3 a {
                font-size: 20px !important
            }

            .es-menu td a {
                font-size: 16px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a {
                font-size: 16px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a {
                font-size: 16px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a {
                font-size: 16px !important
            }

            *[class='gmail-fix'] {
                display: none !important
            }

            .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 {
                text-align: center !important
            }

            .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 {
                text-align: right !important
            }

            .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 {
                text-align: left !important
            }

                .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img {
                    display: inline !important
                }

            .es-button-border {
                display: block !important
            }

            .es-btn-fw {
                border-width: 10px 0px !important;
                text-align: center !important
            }

            .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right {
                width: 100% !important
            }

            .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header {
                width: 100% !important;
                max-width: 600px !important
            }

            .es-adapt-td {
                display: block !important;
                width: 100% !important
            }

            .adapt-img {
                width: 100% !important;
                height: auto !important
            }

            .es-m-p0 {
                padding: 0px !important
            }

            .es-m-p0r {
                padding-right: 0px !important
            }

            .es-m-p0l {
                padding-left: 0px !important
            }

            .es-m-p0t {
                padding-top: 0px !important
            }

            .es-m-p0b {
                padding-bottom: 0 !important
            }

            .es-m-p20b {
                padding-bottom: 20px !important
            }

            .es-mobile-hidden, .es-hidden {
                display: none !important
            }

            tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden {
                width: auto !important;
                overflow: visible !important;
                float: none !important;
                max-height: inherit !important;
                line-height: inherit !important
            }

            tr.es-desk-hidden {
                display: table-row !important
            }

            table.es-desk-hidden {
                display: table !important
            }

            td.es-desk-menu-hidden {
                display: table-cell !important
            }

            .es-menu td {
                width: 1% !important
            }

            table.es-table-not-adapt, .esd-block-html table {
                width: auto !important
            }

            table.es-social {
                display: inline-block !important
            }

                table.es-social td {
                    display: inline-block !important
                }

            a.es-button, button.es-button {
                font-size: 20px !important;
                display: block !important;
                border-left-width: 0px !important;
                border-right-width: 0px !important
            }

            .es-m-margin {
                padding-left: 10px !important;
                padding-right: 10px !important;
                padding-top: 10px !important;
                padding-bottom: 10px !important
            }

            p, ul li, ol li {
                margin-bottom: 12px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li {
                margin-bottom: 12px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li {
                margin-bottom: 12px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li {
                margin-bottom: 12px !important
            }
        }
    </style>
</head>
<body style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
    <div class='es-wrapper-color' style='background-color:#F6F6F6'>
        <!--[if gte mso 9]><v:background xmlns:v='urn:schemas-microsoft-com:vml' fill='t'> <v:fill type='tile' color='#f6f6f6'></v:fill> </v:background><![endif]--><table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'>
            <tr style='border-collapse:collapse'>
                <td class='es-m-margin' valign='top' style='padding:0;Margin:0'>
                    <table cellpadding='0' cellspacing='0' class='es-content' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%'>
                        <tr style='border-collapse:collapse'>
                            <td align='center' style='padding:0;Margin:0'>
                                <table class='es-content-body' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px' cellspacing='0' cellpadding='0' align='center' bgcolor='#FFFFFF'>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0;font-size:0px'><img src='https://naqgik.stripocdn.email/content/guids/CABINET_034eaea83c8d1d71346c232bbb2726eb/images/35461613885865928.png' alt style='display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' width='180'></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='center' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:24px;font-family:helvetica, courier,   serif;line-height:36px;margin-bottom:12px;color:#333333'>Order notification</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>FirstName:</b>&nbsp;##FirstName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>LastName:</b>&nbsp;##LastName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Patronymic:</b>&nbsp;##Patronymic##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Vendor:</b>&nbsp;##Vendor##<br></p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Product/Service:</b>##DiscountName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Email:</b>&nbsp;##VendorEmail##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Phone:</b>&nbsp;##VendorPhone##</p></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b>Discount:</b>&nbsp;<span style='color: #990000;'> ##DiscountValue## %</span></h2></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b><span style='color: #990000;'>##Promocode##</span></b></h2>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'>Confirmation: ##Date##</p></td></tr></table></td></tr></table></td></tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
", "Email template for vendor in english. Words like ##Word## are replaced with values from the database.");
            AddEmailTemplate("RuMessageForUser", @"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
<html xmlns='http://www.w3.org/1999/xhtml' xmlns:o='urn:schemas-microsoft-com:office:office' style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
<head>
    <meta content='width=device-width, initial-scale=1' name='viewport'>
    <meta charset='UTF-8'>
    <meta name='x-apple-disable-message-reformatting'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta content='telephone=no' name='format-detection'>
    <title>пиьсьмо юзеру англ</title> <!--[if (mso 16)]><style type='text/css'>     a {text-decoration: none;}     </style><![endif]--> <!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--> <!--[if gte mso 9]><xml> <o:OfficeDocumentSettings> <o:AllowPNG></o:AllowPNG> <o:PixelsPerInch>96</o:PixelsPerInch> </o:OfficeDocumentSettings> </xml><![endif]--> <!--[if !mso]><!-- -->
    <link href='https://fonts.googleapis.com/css?family=helvetica:400,400i,700,700i' rel='stylesheet'> <!--<![endif]-->
    <style type='text/css'>
        a {
            font-family: helvetica, courier,   serif;
            font-size: 16px;
            text-decoration: underline;
        }

        #outlook a {
            padding: 0;
        }

        .ExternalClass {
            width: 100%;
        }

            .ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {
                line-height: 100%;
            }

        .es-button {
            mso-style-priority: 100 !important;
            text-decoration: none !important;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
            font-size: inherit !important;
            font-family: inherit !important;
            font-weight: inherit !important;
            line-height: inherit !important;
        }

        .es-desk-hidden {
            display: none;
            float: left;
            overflow: hidden;
            width: 0;
            max-height: 0;
            line-height: 0;
            mso-hide: all;
        }

        @media only screen and (max-width:600px) {
            p, ul li, ol li, a {
                font-size: 16px !important;
                line-height: 150% !important
            }

            h1 {
                font-size: 30px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 18px
            }

            h2 {
                font-size: 26px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 16px
            }

            h3 {
                font-size: 20px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 12px
            }

            h1 a {
                font-size: 30px !important
            }

            h2 a {
                font-size: 26px !important
            }

            h3 a {
                font-size: 20px !important
            }

            .es-menu td a {
                font-size: 16px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a {
                font-size: 16px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a {
                font-size: 16px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a {
                font-size: 16px !important
            }

            *[class='gmail-fix'] {
                display: none !important
            }

            .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 {
                text-align: center !important
            }

            .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 {
                text-align: right !important
            }

            .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 {
                text-align: left !important
            }

                .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img {
                    display: inline !important
                }

            .es-button-border {
                display: block !important
            }

            .es-btn-fw {
                border-width: 10px 0px !important;
                text-align: center !important
            }

            .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right {
                width: 100% !important
            }

            .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header {
                width: 100% !important;
                max-width: 600px !important
            }

            .es-adapt-td {
                display: block !important;
                width: 100% !important
            }

            .adapt-img {
                width: 100% !important;
                height: auto !important
            }

            .es-m-p0 {
                padding: 0px !important
            }

            .es-m-p0r {
                padding-right: 0px !important
            }

            .es-m-p0l {
                padding-left: 0px !important
            }

            .es-m-p0t {
                padding-top: 0px !important
            }

            .es-m-p0b {
                padding-bottom: 0 !important
            }

            .es-m-p20b {
                padding-bottom: 20px !important
            }

            .es-mobile-hidden, .es-hidden {
                display: none !important
            }

            tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden {
                width: auto !important;
                overflow: visible !important;
                float: none !important;
                max-height: inherit !important;
                line-height: inherit !important
            }

            tr.es-desk-hidden {
                display: table-row !important
            }

            table.es-desk-hidden {
                display: table !important
            }

            td.es-desk-menu-hidden {
                display: table-cell !important
            }

            .es-menu td {
                width: 1% !important
            }

            table.es-table-not-adapt, .esd-block-html table {
                width: auto !important
            }

            table.es-social {
                display: inline-block !important
            }

                table.es-social td {
                    display: inline-block !important
                }

            a.es-button, button.es-button {
                font-size: 20px !important;
                display: block !important;
                border-left-width: 0px !important;
                border-right-width: 0px !important
            }

            .es-m-margin {
                padding-left: 10px !important;
                padding-right: 10px !important;
                padding-top: 10px !important;
                padding-bottom: 10px !important
            }

            p, ul li, ol li {
                margin-bottom: 12px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li {
                margin-bottom: 12px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li {
                margin-bottom: 12px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li {
                margin-bottom: 12px !important
            }
        }
    </style>
</head>
<body style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
    <div class='es-wrapper-color' style='background-color:#F6F6F6'>
        <!--[if gte mso 9]><v:background xmlns:v='urn:schemas-microsoft-com:vml' fill='t'> <v:fill type='tile' color='#f6f6f6'></v:fill> </v:background><![endif]--><table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'>
            <tr style='border-collapse:collapse'>
                <td class='es-m-margin' valign='top' style='padding:0;Margin:0'>
                    <table cellpadding='0' cellspacing='0' class='es-content' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%'>
                        <tr style='border-collapse:collapse'>
                            <td align='center' style='padding:0;Margin:0'>
                                <table class='es-content-body' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px' cellspacing='0' cellpadding='0' align='center' bgcolor='#FFFFFF'>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0;font-size:0px'><img src='https://naqgik.stripocdn.email/content/guids/CABINET_034eaea83c8d1d71346c232bbb2726eb/images/35461613885865928.png' alt style='display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' width='180'></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='center' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:24px;font-family:helvetica, courier,   serif;line-height:36px;margin-bottom:12px;color:#333333'>Талон покупателя</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Имя:</b>&nbsp;##FirstName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Фамилия:</b>&nbsp;##LastName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Отчество:</b>&nbsp;##Patronymic##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Поставщик:</b>&nbsp;##Vendor##<br></p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Продукт/Услуга:</b>##DiscountName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Электронная почта:</b>&nbsp;##VendorEmail##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Контактный телефон:</b>&nbsp;##VendorPhone##</p></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b>Скидка:</b>&nbsp;<span style='color: #990000;'> ##DiscountValue## %</span></h2></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b><span style='color: #990000;'>##Promocode##</span></b></h2>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'>Дата подтвеждения: ##Date##</p></td></tr></table></td></tr></table></td></tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>", "Email template for user in russian. Words like ##Word## are replaced with values from the database.");
            AddEmailTemplate("RuMessageForVendor", @"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
<html xmlns='http://www.w3.org/1999/xhtml' xmlns:o='urn:schemas-microsoft-com:office:office' style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
<head>
    <meta content='width=device-width, initial-scale=1' name='viewport'>
    <meta charset='UTF-8'>
    <meta name='x-apple-disable-message-reformatting'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta content='telephone=no' name='format-detection'>
    <title>пиьсьмо юзеру англ</title> <!--[if (mso 16)]><style type='text/css'>     a {text-decoration: none;}     </style><![endif]--> <!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--> <!--[if gte mso 9]><xml> <o:OfficeDocumentSettings> <o:AllowPNG></o:AllowPNG> <o:PixelsPerInch>96</o:PixelsPerInch> </o:OfficeDocumentSettings> </xml><![endif]--> <!--[if !mso]><!-- -->
    <link href='https://fonts.googleapis.com/css?family=helvetica:400,400i,700,700i' rel='stylesheet'> <!--<![endif]-->
    <style type='text/css'>
        a {
            font-family: helvetica, courier,   serif;
            font-size: 16px;
            text-decoration: underline;
        }

        #outlook a {
            padding: 0;
        }

        .ExternalClass {
            width: 100%;
        }

            .ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {
                line-height: 100%;
            }

        .es-button {
            mso-style-priority: 100 !important;
            text-decoration: none !important;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
            font-size: inherit !important;
            font-family: inherit !important;
            font-weight: inherit !important;
            line-height: inherit !important;
        }

        .es-desk-hidden {
            display: none;
            float: left;
            overflow: hidden;
            width: 0;
            max-height: 0;
            line-height: 0;
            mso-hide: all;
        }

        @media only screen and (max-width:600px) {
            p, ul li, ol li, a {
                font-size: 16px !important;
                line-height: 150% !important
            }

            h1 {
                font-size: 30px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 18px
            }

            h2 {
                font-size: 26px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 16px
            }

            h3 {
                font-size: 20px !important;
                text-align: center;
                line-height: 120% !important;
                margin-bottom: 12px
            }

            h1 a {
                font-size: 30px !important
            }

            h2 a {
                font-size: 26px !important
            }

            h3 a {
                font-size: 20px !important
            }

            .es-menu td a {
                font-size: 16px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li, .es-header-body a {
                font-size: 16px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li, .es-footer-body a {
                font-size: 16px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a {
                font-size: 16px !important
            }

            *[class='gmail-fix'] {
                display: none !important
            }

            .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 {
                text-align: center !important
            }

            .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 {
                text-align: right !important
            }

            .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-txt-l h3 {
                text-align: left !important
            }

                .es-m-txt-r img, .es-m-txt-c img, .es-m-txt-l img {
                    display: inline !important
                }

            .es-button-border {
                display: block !important
            }

            .es-btn-fw {
                border-width: 10px 0px !important;
                text-align: center !important
            }

            .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right {
                width: 100% !important
            }

            .es-content table, .es-header table, .es-footer table, .es-content, .es-footer, .es-header {
                width: 100% !important;
                max-width: 600px !important
            }

            .es-adapt-td {
                display: block !important;
                width: 100% !important
            }

            .adapt-img {
                width: 100% !important;
                height: auto !important
            }

            .es-m-p0 {
                padding: 0px !important
            }

            .es-m-p0r {
                padding-right: 0px !important
            }

            .es-m-p0l {
                padding-left: 0px !important
            }

            .es-m-p0t {
                padding-top: 0px !important
            }

            .es-m-p0b {
                padding-bottom: 0 !important
            }

            .es-m-p20b {
                padding-bottom: 20px !important
            }

            .es-mobile-hidden, .es-hidden {
                display: none !important
            }

            tr.es-desk-hidden, td.es-desk-hidden, table.es-desk-hidden {
                width: auto !important;
                overflow: visible !important;
                float: none !important;
                max-height: inherit !important;
                line-height: inherit !important
            }

            tr.es-desk-hidden {
                display: table-row !important
            }

            table.es-desk-hidden {
                display: table !important
            }

            td.es-desk-menu-hidden {
                display: table-cell !important
            }

            .es-menu td {
                width: 1% !important
            }

            table.es-table-not-adapt, .esd-block-html table {
                width: auto !important
            }

            table.es-social {
                display: inline-block !important
            }

                table.es-social td {
                    display: inline-block !important
                }

            a.es-button, button.es-button {
                font-size: 20px !important;
                display: block !important;
                border-left-width: 0px !important;
                border-right-width: 0px !important
            }

            .es-m-margin {
                padding-left: 10px !important;
                padding-right: 10px !important;
                padding-top: 10px !important;
                padding-bottom: 10px !important
            }

            p, ul li, ol li {
                margin-bottom: 12px !important
            }

            .es-header-body p, .es-header-body ul li, .es-header-body ol li {
                margin-bottom: 12px !important
            }

            .es-footer-body p, .es-footer-body ul li, .es-footer-body ol li {
                margin-bottom: 12px !important
            }

            .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li {
                margin-bottom: 12px !important
            }
        }
    </style>
</head>
<body style='width:100%;font-family:helvetica, courier,   serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0'>
    <div class='es-wrapper-color' style='background-color:#F6F6F6'>
        <!--[if gte mso 9]><v:background xmlns:v='urn:schemas-microsoft-com:vml' fill='t'> <v:fill type='tile' color='#f6f6f6'></v:fill> </v:background><![endif]--><table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top'>
            <tr style='border-collapse:collapse'>
                <td class='es-m-margin' valign='top' style='padding:0;Margin:0'>
                    <table cellpadding='0' cellspacing='0' class='es-content' align='center' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%'>
                        <tr style='border-collapse:collapse'>
                            <td align='center' style='padding:0;Margin:0'>
                                <table class='es-content-body' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:transparent;width:600px' cellspacing='0' cellpadding='0' align='center' bgcolor='#FFFFFF'>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0;font-size:0px'><img src='https://naqgik.stripocdn.email/content/guids/CABINET_034eaea83c8d1d71346c232bbb2726eb/images/35461613885865928.png' alt style='display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic' width='180'></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='center' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:24px;font-family:helvetica, courier,   serif;line-height:36px;margin-bottom:12px;color:#333333'>Уведомление о заказе</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Имя:</b>&nbsp;##FirstName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Фамилия:</b>&nbsp;##LastName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Отчество:</b>&nbsp;##Patronymic##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Поставщик:</b>&nbsp;##Vendor##<br></p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Продукт/Услуга:</b>##DiscountName##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'>&nbsp;</p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Электронная почта:</b>&nbsp;##VendorEmail##</p>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'><b>Контактный телефон:</b>&nbsp;##VendorPhone##</p></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0'><h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b>Скидка:</b>&nbsp;<span style='color: #990000;'> ##DiscountValue## %</span></h2></td></tr></table></td></tr></table></td>
                                    </tr>
                                    <tr style='border-collapse:collapse'>
                                        <td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'>
                                            <table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                <tr style='border-collapse:collapse'>
                                                    <td align='center' valign='top' style='padding:0;Margin:0;width:560px'>
                                                        <table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'>
                                                            <tr style='border-collapse:collapse'>
                                                                <td align='left' style='padding:0;Margin:0'>
                                                                    <h2 style='Margin:0;line-height:29px;mso-line-height-rule:exactly;font-family:arial, ' helvetica neue', helvetica, sans-serif;font-size:24px;font-style:normal;font-weight:normal;color:#666666;margin-bottom:15px'><b><span style='color: #990000;'>##Promocode##</span></b></h2>
                                                                    <p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333;display:none'><br></p>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr style='border-collapse:collapse'><td align='left' style='padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px'><table cellpadding='0' cellspacing='0' width='100%' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' valign='top' style='padding:0;Margin:0;width:560px'><table cellpadding='0' cellspacing='0' width='100%' role='presentation' style='mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px'><tr style='border-collapse:collapse'><td align='center' style='padding:0;Margin:0'><p style='Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-size:16px;font-family:helvetica, courier,   serif;line-height:24px;margin-bottom:12px;color:#333333'>Дата подтвеждения: ##Date##</p></td></tr></table></td></tr></table></td></tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>", "Email template for vendor in russian. Words like ##Word## are replaced with values from the database.");
        }
    }
}
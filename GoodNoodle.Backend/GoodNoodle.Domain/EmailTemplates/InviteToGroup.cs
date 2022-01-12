﻿namespace GoodNoodle.Domain.EmailTemplates;

public static class InviteToGroup
{
    public const string content = @"
<!doctype html>
<html>
  <head>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'/>
    <meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />
    <title>Simple Transactional Email</title>
  </head>
  <body
  class=''
  style='
    background-color: #f6f6f6;
    font-family: sans-serif;
    -webkit-font-smoothing: antialiased;
    font-size: 14px;
    line-height: 1.4;
    margin: 0;
    padding: 0;
    -ms-text-size-adjust: 100%;
    -webkit-text-size-adjust: 100%;
  '
>
  <span
    class='preheader'
    style='
      color: transparent;
      display: none;
      height: 0;
      max-height: 0;
      max-width: 0;
      opacity: 0;
      overflow: hidden;
      mso-hide: all;
      visibility: hidden;
      width: 0;
    '
    >This is preheader text. Some clients will show this text as a
    preview.</span
  >
  <table
    role='presentation'
    border='0'
    cellpadding='0'
    cellspacing='0'
    class='body'
    style='
      border-collapse: separate;
      mso-table-lspace: 0pt;
      mso-table-rspace: 0pt;
      background-color: #f6f6f6;
      width: 100%;
    '
    width='100%'
    bgcolor='#f6f6f6'
  >
    <tr>
      <td
        style='font-family: sans-serif; font-size: 14px; vertical-align: top'
        valign='top'
      >
        &nbsp;
      </td>
      <td
        class='container'
        style='
          font-family: sans-serif;
          font-size: 14px;
          vertical-align: top;
          display: block;
          max-width: 580px;
          padding: 10px;
          width: 580px;
          margin: 0 auto;
        '
        width='580'
        valign='top'
      >
        <div
          class='content'
          style='
            box-sizing: border-box;
            display: block;
            margin: 0 auto;
            max-width: 580px;
            padding: 10px;
          '
        >
          <!-- START CENTERED WHITE CONTAINER -->
          <table
            role='presentation'
            class='main'
            style='
              border-collapse: separate;
              mso-table-lspace: 0pt;
              mso-table-rspace: 0pt;
              background: #ffffff;
              border-radius: 3px;
              width: 100%;
            '
            width='100%'
          >
            <!-- START MAIN CONTENT AREA -->
            <tr>
              <td
                class='wrapper'
                style='
                  font-family: sans-serif;
                  font-size: 14px;
                  vertical-align: top;
                  box-sizing: border-box;
                  padding: 20px;
                '
                valign='top'
              >
                <table
                  role='presentation'
                  border='0'
                  cellpadding='0'
                  cellspacing='0'
                  style='
                    border-collapse: separate;
                    mso-table-lspace: 0pt;
                    mso-table-rspace: 0pt;
                    width: 100%;
                  '
                  width='100%'
                >
                  <tr>
                    <td
                      style='
                        font-family: sans-serif;
                        font-size: 14px;
                        vertical-align: top;
                      '
                      valign='top'
                    >
                      <p
                        style='
                          font-family: sans-serif;
                          font-size: 14px;
                          font-weight: normal;
                          margin: 0;
                          margin-bottom: 15px;
                        '
                      >
                        Hi there,
                      </p>
                      <p
                        style='
                          font-family: sans-serif;
                          font-size: 14px;
                          font-weight: normal;
                          margin: 0;
                          margin-bottom: 15px;
                        '
                      >
                        you got invited to the great GoodNoodle group ✨ @GROUP_NAME ✨. To join just click the button below.
                      </p>
                      <table
                        role='presentation'
                        border='0'
                        cellpadding='0'
                        cellspacing='0'
                        class='btn btn-primary'
                        style='
                          border-collapse: separate;
                          mso-table-lspace: 0pt;
                          mso-table-rspace: 0pt;
                          box-sizing: border-box;
                          width: 100%;
                        '
                        width='100%'
                      >
                        <tbody>
                          <tr>
                            <td
                              align='left'
                              style='
                                font-family: sans-serif;
                                font-size: 14px;
                                vertical-align: top;
                                padding-bottom: 15px;
                              '
                              valign='top'
                            >
                              <table
                                role='presentation'
                                border='0'
                                cellpadding='0'
                                cellspacing='0'
                                style='
                                  border-collapse: separate;
                                  mso-table-lspace: 0pt;
                                  mso-table-rspace: 0pt;
                                  width: auto;
                                '
                              >
                                <tbody>
                                  <tr>
                                    <td
                                      style='
                                        font-family: sans-serif;
                                        font-size: 14px;
                                        vertical-align: top;
                                        border-radius: 5px;
                                        text-align: center;
                                        background-color: #3498db;
                                      '
                                      valign='top'
                                      align='center'
                                      bgcolor='#3498db'
                                    >
                                      <a
                                        href='@INVITE_LINK'
                                        target='_blank'
                                        style='
                                          border: solid 1px #3498db;
                                          border-radius: 5px;
                                          box-sizing: border-box;
                                          cursor: pointer;
                                          display: inline-block;
                                          font-size: 14px;
                                          font-weight: bold;
                                          margin: 0;
                                          padding: 12px 25px;
                                          text-decoration: none;
                                          text-transform: capitalize;
                                          background-color: #3498db;
                                          border-color: #3498db;
                                          color: #ffffff;
                                        '
                                        >Join group</a
                                      >
                                    </td>
                                  </tr>
                                </tbody>
                              </table>
                            </td>
                          </tr>
                        </tbody>
                      </table>
                      <p
                        style='
                          font-family: sans-serif;
                          font-size: 14px;
                          font-weight: normal;
                          margin: 0;
                          margin-bottom: 15px;
                        '
                      >
                        If you dont want to join you can ignore this email.
                      </p>
                      <p
                        style='
                          font-family: sans-serif;
                          font-size: 14px;
                          font-weight: normal;
                          margin: 0;
                          margin-bottom: 15px;
                        '
                      >
                        Stay awesome!
                      </p>
                    </td>
                  </tr>
                </table>
              </td>
            </tr>

            <!-- END MAIN CONTENT AREA -->
          </table>
          <!-- END CENTERED WHITE CONTAINER -->

          <!-- START FOOTER -->
          <div
            class='footer'
            style='
              clear: both;
              margin-top: 10px;
              text-align: center;
              width: 100%;
            '
          >
            <table
              role='presentation'
              border='0'
              cellpadding='0'
              cellspacing='0'
              style='
                border-collapse: separate;
                mso-table-lspace: 0pt;
                mso-table-rspace: 0pt;
                width: 100%;
              '
              width='100%'
            >
              <tr>
                <td
                  class='content-block'
                  style='
                    font-family: sans-serif;
                    vertical-align: top;
                    padding-bottom: 10px;
                    padding-top: 10px;
                    color: #999999;
                    font-size: 12px;
                    text-align: center;
                  '
                  valign='top'
                  align='center'
                >
                  <span
                    class='apple-link'
                    style='color: #999999; font-size: 12px; text-align: center'
                    >GoodNoodle 2021</span
                  >
                </td>
              </tr>
            </table>
          </div>
          <!-- END FOOTER -->
        </div>
      </td>
      <td
        style='font-family: sans-serif; font-size: 14px; vertical-align: top'
        valign='top'
      >
        &nbsp;
      </td>
    </tr>
  </table>
</body>

</html>
    ";
}
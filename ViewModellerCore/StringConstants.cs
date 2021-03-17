using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModellerCore
{
    public static class StringConstants
    {
        public static string CommandTemplate = @"private DelegateCommand {0};
public DelegateCommand {1} {{get=>{0} ?? ({0} = new DelegateCommand({1}_Execute));}}
private void {1}_Execute()
{{
    throw new NotImplementedException();
}}";
        public static string TCommandTemplate = @"private DelegateCommand<{2}> {0};
public DelegateCommand<{2}> {1} {{get=>{0} ?? ({0} = new DelegateCommand<{2}>({1}_Execute));}}
private void {1}_Execute({2} param)
{{
    throw new NotImplementedException();
}}";
        public static string PropertyTemplate = @"private {0} {1};
public {0} {2} {{ get=>{1}; set => SetProperty(ref {1}, value);}}";
    }
}

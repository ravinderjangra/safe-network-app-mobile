﻿// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

using System.Collections.Generic;

namespace MobileSnapp.Models.Onboarding
{
    public class CreateAccountOnboardingStaticContent
    {
        public List<CreateAccountOnboardingItem> CreateAccountOnboarding { get; set; }

        public List<CreateAccountOnboardingItem> CreateAccountOptionList { get; set; }
    }

    public class CreateAccountOnboardingItem
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public bool? IsDesktopOnly { get; set; }
    }
}
